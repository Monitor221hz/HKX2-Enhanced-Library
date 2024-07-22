using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HKX2
{
    // hkb@eventPayloadList Signatire: 0x3d2dbd34 size: 32 flags: FLAGS_NONE

    // payloads class: hkb@eventPayload Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkb@eventPayloadList : hkb@eventPayload, IEquatable<hkb@eventPayloadList?>
    {
        public IList<hkb@eventPayload> payloads { set; get; } = Array.Empty<hkb@eventPayload>();

        public override uint Signature { set; get; } = 0x3d2dbd34;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            payloads = des.ReadClassPointerArray<hkb@eventPayload>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, payloads);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            payloads = xd.ReadClassPointerArray<hkb@eventPayload>(xe, nameof(payloads));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray(xe, nameof(payloads), payloads);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkb@eventPayloadList);
        }

        public bool Equals(hkb@eventPayloadList? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   payloads.SequenceEqual(other.payloads) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(payloads.Aggregate(0, (x, y) => x ^ y?.GetHashCode() ?? 0));
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

