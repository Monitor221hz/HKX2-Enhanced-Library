using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HKX2
{
    // hkb@eventRangeDataArray Signatire: 0x330a56ee size: 32 flags: FLAGS_NONE

    // @eventData class: hkb@eventRangeData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkb@eventRangeDataArray : hkReferencedObject, IEquatable<hkb@eventRangeDataArray?>
    {
        public IList<hkb@eventRangeData> @eventData { set; get; } = Array.Empty<hkb@eventRangeData>();

        public override uint Signature { set; get; } = 0x330a56ee;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            @eventData = des.ReadClassArray<hkb@eventRangeData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, @eventData);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            @eventData = xd.ReadClassArray<hkb@eventRangeData>(xe, nameof(@eventData));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray(xe, nameof(@eventData), @eventData);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkb@eventRangeDataArray);
        }

        public bool Equals(hkb@eventRangeDataArray? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   @eventData.SequenceEqual(other.@eventData) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(@eventData.Aggregate(0, (x, y) => x ^ y?.GetHashCode() ?? 0));
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

