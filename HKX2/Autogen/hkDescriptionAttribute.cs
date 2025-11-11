using System;
using System.Xml.Linq;

namespace HKX2E
{
    // hkDescriptionAttribute Signatire: 0xe9f9578a size: 8 flags: FLAGS_NONE

    //  string class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum:
    public partial class hkDescriptionAttribute : IHavokObject, IEquatable<hkDescriptionAttribute?>
    {
        public string _string { set; get; } = "";

        public virtual uint Signature { set; get; } = 0xe9f9578a;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            _string = des.ReadCString(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteCString(bw, _string);
        }

        public virtual void ReadXml(IHavokXmlReader xd, XElement xe)
        {
            _string = xd.ReadString(xe, LITERAL.STRING);
        }

        public virtual void WriteXml(IHavokXmlWriter xs, XElement xe)
        {
            xs.WriteString(xe, LITERAL.STRING, _string);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkDescriptionAttribute);
        }

        public bool Equals(hkDescriptionAttribute? other)
        {
            return other is not null
                && (
                    _string is null && other._string is null
                    || _string == other._string
                    || _string is null && other._string == ""
                    || _string == "" && other._string is null
                )
                && Signature == other.Signature;
            ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(_string);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}
