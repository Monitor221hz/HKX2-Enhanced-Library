using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkb@eventInfo Signatire: 0x5874eed4 size: 4 flags: FLAGS_NONE

    // flags class:  Type.TYPE_FLAGS Type.TYPE_UINT32 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: Flags
    public partial class hkb@eventInfo : IHavokObject, IEquatable<hkb@eventInfo?>
    {
        public uint flags { set; get; }

        public virtual uint Signature { set; get; } = 0x5874eed4;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            flags = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(flags);
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            flags = xd.ReadFlag<Flags, uint>(xe, nameof(flags));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteFlag<Flags, uint>(xe, nameof(flags), flags);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkb@eventInfo);
        }

        public bool Equals(hkb@eventInfo? other)
        {
            return other is not null &&
                   flags.Equals(other.flags) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(flags);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

