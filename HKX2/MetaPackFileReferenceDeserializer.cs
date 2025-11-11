using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HKX2E.Utils;

namespace HKX2E
{
    public class MetaPackFileReferenceDeserializer : MetaPackFileDeserializer
    {
        private int nodeCount = 0;
        private Dictionary<string, int> nameOrderLookup = new();

        // store deserialized
        private Dictionary<IHavokObject, HavokObjectReference> objectReferenceMap = new(
            ReferenceEqualityComparer.Instance
        );
        private Dictionary<string, List<IHavokReference>> referenceNameMap = new();
        private Stack<IHavokObject> ownerStack = new();

        protected virtual ulong GetIndexFromName(string name) => ulong.Parse(name.AsSpan(1));

        public virtual void UpdateObjectByName(string name, IHavokObject newObject)
        {
            lock (nodeIDMap)
            {
                if (nodeIDMap.TryGetValue(GetIndexFromName(name), out var existingObject))
                {
                    UpdateDirectReference(existingObject, newObject);
                    UpdatePropertyReferences(name, newObject);
                    //objectNameMap[name] = newObject;
                }
#if DEBUG_VERBOSE
                else
                {
                    Debug.WriteLine($"Could not find object with name {name}");
                }
#endif
            }
        }

        public virtual void UpdateDirectReference(
            IHavokObject existingObject,
            IHavokObject newObject
        )
        {
            if (objectReferenceMap.TryGetValue(existingObject, out var existingReference))
            {
                existingReference.Update(newObject);
            }
#if DEBUG_VERBOSE
            else
            {
                Debug.WriteLine(
                    $"Could not update direct reference for object of type {existingObject.GetType()}"
                );
            }
#endif
        }

        public virtual void UpdatePropertyReferences<T>(string name, T newObject)
            where T : IHavokObject
        {
            if (referenceNameMap.TryGetValue(name, out var havokReferences))
            {
                foreach (IHavokReference reference in havokReferences)
                {
                    reference.Update(newObject);
                }
            }
        }

        public virtual void UpdateMapping(string name, IHavokObject newObject)
        {
            var index = GetIndexFromName(name);
            if (nodeIDMap.ContainsKey(index))
            {
                nodeIDMap[index] = newObject;
            }
#if DEBUG_VERBOSE
            else
            {
                Debug.WriteLine($"Could not update mapping for object {name}");
            }
#endif
        }

        public virtual void AddPropertyReference(
            string name,
            IHavokObject owner,
            string propertyName,
            int listIndex
        )
        {
            HavokIndexPropertyReference reference = new HavokIndexPropertyReference(
                GetObjectReference(owner),
                propertyName,
                listIndex
            );
            List<IHavokReference> referenceList;
            lock (referenceNameMap)
            {
                if (referenceNameMap.TryGetValue(name, out referenceList!))
                {
                    referenceList.Add(reference);
                    return;
                }
            }
            referenceList = new();
            referenceList.Add(reference);
            lock (referenceNameMap)
            {
                referenceNameMap.Add(name, referenceList);
            }
        }

        public void AddPropertyReference(string name, IHavokObject owner, string propertyName)
        {
            HavokPropertyReference reference = new HavokPropertyReference(
                GetObjectReference(owner),
                propertyName
            );
            List<IHavokReference> referenceList;
            lock (referenceNameMap)
            {
                if (referenceNameMap.TryGetValue(name, out referenceList!))
                {
                    referenceList.Add(reference);
                    return;
                }
            }
            referenceList = new();
            referenceList.Add(reference);
            lock (referenceNameMap)
            {
                referenceNameMap.Add(name, referenceList);
            }
        }

        public HavokObjectReference GetObjectReference(IHavokObject havokObject)
        {
            lock (objectReferenceMap)
            {
                if (objectReferenceMap.TryGetValue(havokObject, out var existingReference))
                {
                    return existingReference;
                }
            }
            HavokObjectReference objectReference = new(havokObject);
            lock (objectReferenceMap)
            {
                objectReferenceMap.Add(havokObject, objectReference);
            }
            return objectReference;
        }

        public override T ReadClassPointer<T>(BinaryReaderEx br)
        {
            PadToPointerSizeIfPaddingOption(br);

            var key = (uint)br.Position;

            // Consume pointer
            br.AssertUSize(0);

            // Do a global fixup lookup
            if (!_dataSection._globalMap.ContainsKey(key))
                return default!;

            var f = _dataSection._globalMap[key];
            var klass = ConstructVirtualClass(br, f.Dst);

            if (klass.GetType().IsAssignableTo(typeof(T)))
                return (T)klass;

            if (!_ignoreNonFatalError)
                throw new Exception(
                    $@"Could not convert '{typeof(T)}' to '{klass.GetType()}'. Is source malformed?"
                );

            // TODO: this assume klass was read on correct block
            return hkDummyBuilder.CreateDummy(klass, typeof(T));
        }

        protected override IHavokObject ConstructVirtualClass(BinaryReaderEx br, uint offset)
        {
            if (_deserializedObjects.ContainsKey(offset))
                return _deserializedObjects[offset];

            var fixup = _dataSection._virtualMap[offset];
            var hkClassName = _classnames.OffsetClassNamesMap[fixup.Dst].ClassName;

            var hkClass = System.Type.GetType($@"HKX2E.{hkClassName}");
            if (hkClass is null)
                throw new Exception($@"Havok class type '{hkClassName}' not found!");

            var ret = (IHavokObject)Activator.CreateInstance(hkClass)!;
            if (ret is null)
                throw new Exception($@"Failed to Activator.CreateInstance({hkClass})");

            br.StepIn(offset);
            var explicitID = ret.ReadMetaData(this, br);
            if (explicitID > 0)
            {
                nodeIDMap.TryAdd(explicitID, ret);
            }
            ret.Read(this, br);
            br.StepOut();

            _deserializedObjects.Add(offset, ret);
            ownerStack.Push(ret);
            return ret;
        }

        public override void DeserializePartially(BinaryReaderEx br)
        {
            br.StepIn(0x11);
            br.BigEndian = br.ReadByte() == 0x0;
            br.StepOut();

            _header = new HKXHeader(br);

            // Read the 3 sections in the file
            if (_header.SectionOffset == -1)
            {
                br.Position = 0x40;
            }
            else
            {
                br.Position = _header.SectionOffset + 0x40;
            }

            _classSection = new HKXSection(br, _header.ContentsVersionString) { SectionID = 0 };
            _typeSection = new HKXSection(br, _header.ContentsVersionString) { SectionID = 1 };
            _dataSection = new HKXSection(br, _header.ContentsVersionString) { SectionID = 2 };

            // Process the class names
            _classnames = _classSection.ReadClassnamesWithMetaData(br);
        }

        public override IHavokObject Deserialize(
            BinaryReaderEx br,
            bool ignoreNonFatalError = false
        )
        {
            _ignoreNonFatalError = ignoreNonFatalError;

            DeserializePartially(br);

            // Deserialize the objects
            _deserializedObjects = new Dictionary<uint, IHavokObject>();
            var br2 = new BinaryReaderEx(
                _header.Endian == 0,
                _header.PointerSize == 8,
                _dataSection.SectionData
            );
            return ConstructVirtualClass(br2, 0);
        }
    }
}
