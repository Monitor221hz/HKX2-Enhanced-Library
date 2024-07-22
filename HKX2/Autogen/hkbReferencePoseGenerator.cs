using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbReferencePoseGenerator Signatire: 0x26a5675a size: 80 flags: FLAGS_NONE

    // m_skeleton m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbReferencePoseGenerator : hkbGenerator, IEquatable<hkbReferencePoseGenerator?>
    {
        private object? m_skeleton { set; get; }

        public override uint Signature { set; get; } = 0x26a5675a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_skeleton));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbReferencePoseGenerator);
        }

        public bool Equals(hkbReferencePoseGenerator? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

