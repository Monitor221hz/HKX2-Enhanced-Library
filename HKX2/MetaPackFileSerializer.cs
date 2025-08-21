using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKX2E
{
    public class MetaPackFileSerializer : PackFileSerializer
    {
        protected Dictionary<IHavokObject, ulong> idNodeMap = new(ReferenceEqualityComparer.Instance);
        public void ShareContext(HavokXmlDeserializerContext context)
        {
            foreach (var kvp in context.ObjectNameMap)
            {
                idNodeMap.TryAdd(kvp.Value, ulong.Parse(kvp.Key.AsSpan(1)));
            }
        }

        public override void Serialize(IHavokObject rootObject, BinaryWriterEx bw, HKXHeader header)
        {
            _header = header;
            bw.BigEndian = _header.Endian == 0;

            _header.Write(bw);
            // Initialize bookkeeping structures
            idNodeMap.Clear();
            _localFixups = new List<LocalFixup>();
            _globalFixups = new List<GlobalFixup>();
            _virtualFixups = new List<VirtualFixup>();

            _globalLookup = new Dictionary<IHavokObject, uint>(ReferenceEqualityComparer.Instance);
            _virtualLookup = new Dictionary<string, uint>();

            _localWriteQueues = new List<Queue<Action>>();
            _serializationQueues = new List<Queue<IHavokObject>>();
            _pendingGlobals = new Dictionary<IHavokObject, List<uint>>(ReferenceEqualityComparer.Instance);
            _pendingVirtuals = new HashSet<IHavokObject>(ReferenceEqualityComparer.Instance);

            _serializedObjects = new HashSet<IHavokObject>(ReferenceEqualityComparer.Instance);

            // Memory stream for writing all the class definitions
            var classms = new MemoryStream();
            var classbw = new BinaryWriterEx(
                _header.Endian == 0, _header.PointerSize == 8, classms);

            // Data memory stream for havok objects
            // debugging
            //var datams = new FileStream(".\\dump.hex", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete, 1, FileOptions.WriteThrough);
            var datams = new MemoryStream();
            var databw = new BinaryWriterEx(
                _header.Endian == 0, _header.PointerSize == 8, datams);

            // Populate class names with some stuff havok always has
            var hkClass = new HKXClassName { ClassName = "hkClass", Signature = 0x75585EF6 };
            var hkClassMember = new HKXClassName { ClassName = "hkClassMember", Signature = 0x5C7EA4C2 };
            var hkClassEnum = new HKXClassName { ClassName = "hkClassEnum", Signature = 0x8A3609CF };
            var hkClassEnumItem = new HKXClassName { ClassName = "hkClassEnumItem", Signature = 0xCE6F8A6C };

            hkClass.Write(classbw);
            hkClassMember.Write(classbw);
            hkClassEnum.Write(classbw);
            hkClassEnumItem.Write(classbw);

            _serializationQueues.Add(new Queue<IHavokObject>());
            _serializationQueues[0].Enqueue(rootObject);
            _localWriteQueues.Add(new Queue<Action>());
            _pendingVirtuals.Add(rootObject);

            while (_serializationQueues.Count > 1 || _serializationQueues[0].Count > 0)
            {
                var sq = _serializationQueues.Last();

                while (sq != null && sq.Count == 0 && _serializationQueues.Count > 1)
                {
                    _serializationQueues.RemoveAt(_serializationQueues.Count - 1);
                    sq = _serializationQueues.Last();
                }

                if (sq == null || sq.Count == 0) continue;

                var obj = sq.Dequeue();
                _currentSerializationQueue = _serializationQueues.Count - 1;

                if (_serializedObjects.Contains(obj)) continue;

                // See if we need to add virtual bookkeeping
                if (_pendingVirtuals.Contains(obj))
                {
                    _pendingVirtuals.Remove(obj);
                    var classname = obj.GetType().Name;
                    if (!_virtualLookup.ContainsKey(classname))
                    {
                        // Need to create a new class name entry and record the position
                        var cname = new HKXClassName
                        {
                            ClassName = classname,
                            Signature = obj.Signature
                        };
                        var offset = (uint)classbw.Position;
                        cname.Write(classbw);
                        _virtualLookup.Add(classname, offset + 5);
                    }

                    // Create a new Virtual fixup for this object
                    var vfu = new VirtualFixup
                    {
                        Src = (uint)databw.Position,
                        DstSectionIndex = 0,
                        Dst = _virtualLookup[classname]
                    };
                    _virtualFixups.Add(vfu);

                    // See if we have any pending global references to this object
                    if (_pendingGlobals.ContainsKey(obj))
                    {
                        // If so, create all the needed global fixups
                        foreach (var src in _pendingGlobals[obj])
                        {
                            var gfu = new GlobalFixup
                            {
                                Src = src,
                                DstSectionIndex = 2,
                                Dst = (uint)databw.Position
                            };
                            _globalFixups.Add(gfu);
                        }

                        _pendingGlobals.Remove(obj);
                    }

                    // Add global lookup
                    _globalLookup.Add(obj, (uint)databw.Position);
                }
                if (idNodeMap.TryGetValue(obj, out var id)) 
                {  
                    obj.WriteMetaData(this, databw, id); 
                }
                else 
                { 
                    obj.WriteMetaData(this, databw, 0); 
                }
                obj.Write(this, databw);
                _serializedObjects.Add(obj);
                databw.Pad(16);

                // Write local data (such as array contents and strings)
                while (_localWriteQueues.Count > 1 || _localWriteQueues[0].Count > 0)
                {
                    var q = _localWriteQueues.Last();
                    while (q != null && q.Count == 0 && _localWriteQueues.Count > 1)
                    {
                        if (_localWriteQueues.Count > 1) _localWriteQueues.RemoveAt(_localWriteQueues.Count - 1);

                        q = _localWriteQueues.Last();

                        // Do alignment at the popping of a queue frame
                        databw.Pad(16);
                    }

                    if (q == null || q.Count == 0)
                    {
                        _currentLocalWriteQueue = _localWriteQueues.Count - 1;
                        continue;
                    }

                    var act = q.Dequeue();
                    _currentLocalWriteQueue = _localWriteQueues.Count - 1;
                    act.Invoke();
                }

                databw.Pad(16);
            }

            var classNames = new HKXSection()
            {
                SectionID = 0,
                SectionTag = "__classnames__",
                SectionData = classms.ToArray(),
                ContentsVersionString = _header.ContentsVersionString
            };
            var types = new HKXSection { SectionID = 1, SectionTag = "__types__", SectionData = Array.Empty<byte>(), ContentsVersionString = _header.ContentsVersionString };
            // debugging
            //var ms = new MemoryStream();
            //var tempPosition = datams.Position;
            //datams.Position = 0;
            //datams.CopyTo(ms);
            //datams.Position = tempPosition;

            var data = new HKXSection
            {
                SectionID = 2,
                SectionTag = "__data__",
                SectionData = datams.ToArray(),
                LocalFixups = _localFixups.OrderBy(x => x.Dst).ToList(),
                GlobalFixups = _globalFixups.OrderBy(x => x.Src).ToList(),
                VirtualFixups = _virtualFixups,
                ContentsVersionString = _header.ContentsVersionString
            };

            classNames.WriteHeader(bw);
            types.WriteHeader(bw);
            data.WriteHeader(bw);

            classNames.WriteData(bw);
            types.WriteData(bw);
            data.WriteData(bw);
        }
    }
}
