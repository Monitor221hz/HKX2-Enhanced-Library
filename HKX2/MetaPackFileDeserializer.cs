using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKX2E
{
    public class MetaPackFileDeserializer : PackFileDeserializer
    {
        ulong nodeCount = 0; 
        protected Dictionary<ulong, IHavokObject> nodeIDMap = new();
        protected Dictionary<IHavokObject, ulong> objOrderLookup = new(ReferenceEqualityComparer.Instance);
        public MetaPackFileDeserializerContext Context => new(nodeIDMap);
        
        public ulong GetOrder(IHavokObject havokObject) => objOrderLookup.TryGetValue(havokObject, out ulong order) ? order : 0; 
        protected override IHavokObject ConstructVirtualClass(BinaryReaderEx br, uint offset)
        {
            if (_deserializedObjects.ContainsKey(offset)) return _deserializedObjects[offset];

            var fixup = _dataSection._virtualMap[offset];
            var hkClassName = _classnames.OffsetClassNamesMap[fixup.Dst].ClassName;

            var hkClass = System.Type.GetType($@"HKX2E.{hkClassName}");
            if (hkClass is null) throw new Exception($@"Havok class type '{hkClassName}' not found!");

            var ret = (IHavokObject)Activator.CreateInstance(hkClass)!;
            if (ret is null) throw new Exception($@"Failed to Activator.CreateInstance({hkClass})");

            br.StepIn(offset);
            var explicitID = ret.ReadMetaData(this, br); 
            if (explicitID > 0)
            {
                nodeIDMap.TryAdd(explicitID, ret);
            }
            objOrderLookup.TryAdd(ret, nodeCount++); 
            ret.Read(this, br);
            br.StepOut();

            _deserializedObjects.Add(offset, ret);
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
        public override IHavokObject Deserialize(BinaryReaderEx br, bool ignoreNonFatalError = false)
        {
            _ignoreNonFatalError = ignoreNonFatalError;

            DeserializePartially(br);

            // Deserialize the objects
            _deserializedObjects = new Dictionary<uint, IHavokObject>();
            var br2 = new BinaryReaderEx(_header.Endian == 0, _header.PointerSize == 8, _dataSection.SectionData);
            return ConstructVirtualClass(br2, 0);
        }
    }
}
