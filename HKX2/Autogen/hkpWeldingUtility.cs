using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkpWeldingUtility Signatire: 0xb2b41feb size: 1 flags: FLAGS_NONE


    public partial class hkpWeldingUtility : IHavokObject, IEquatable<hkpWeldingUtility?>
    {
        private byte[] unk0 = new byte[1];

        public virtual uint Signature { set; get; } = 0xb2b41feb;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            unk0 = br.ReadBytes(1);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBytes(unk0);
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {

        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {

        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkpWeldingUtility);
        }

        public bool Equals(hkpWeldingUtility? other)
        {
            return other is not null &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();

            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

