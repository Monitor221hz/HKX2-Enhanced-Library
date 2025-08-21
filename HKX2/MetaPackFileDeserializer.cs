using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKX2E
{
    public class MetaPackFileDeserializer : PackFileDeserializer
    {
        protected Dictionary<ulong, IHavokObject> nodeIDMap = new();
        public MetaPackFileDeserializerContext Context => new(nodeIDMap);
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
            ret.Read(this, br);
            br.StepOut();

            _deserializedObjects.Add(offset, ret);
            return ret;
        }
    }
}
