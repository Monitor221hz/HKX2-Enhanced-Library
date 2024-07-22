using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbWorldEnums Signatire: 0x25640b46 size: 1 flags: FLAGS_NONE


    public partial class hkbWorldEnums : IHavokObject, IEquatable<hkbWorldEnums?>
    {
        private byte[] unk0 = new byte[1];

        public virtual uint Signature { set; get; } = 0x25640b46;

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
            return Equals(obj as hkbWorldEnums);
        }

        public bool Equals(hkbWorldEnums? other)
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

