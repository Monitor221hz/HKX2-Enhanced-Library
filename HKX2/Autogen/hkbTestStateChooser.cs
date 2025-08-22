using System;
using System.Xml.Linq;

namespace HKX2E
{
    // hkbTestStateChooser Signatire: 0xc0fcc436 size: 32 flags: FLAGS_NONE

    //  int class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // real class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    //  string class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbTestStateChooser : hkbStateChooser, IEquatable<hkbTestStateChooser?>
    {
        public int _int { set; get; }
        public float real { set; get; }
        public string _string { set; get; } = "";

        public override uint Signature { set; get; } = 0xc0fcc436;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            _int = br.ReadInt32();
            real = br.ReadSingle();
            _string = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(_int);
            bw.WriteSingle(real);
            s.WriteStringPointer(bw, _string);
        }

        public override void ReadXml(IHavokXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            _int = xd.ReadInt32(xe, LITERAL.INT);
            real = xd.ReadSingle(xe, nameof(real));
            _string = xd.ReadString(xe, LITERAL.STRING);
        }

        public override void WriteXml(IHavokXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, LITERAL.INT, _int);
            xs.WriteFloat(xe, nameof(real), real);
            xs.WriteString(xe, LITERAL.STRING, _string);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbTestStateChooser);
        }

        public bool Equals(hkbTestStateChooser? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   _int.Equals(other._int) &&
                   real.Equals(other.real) &&
                   (_string is null && other._string is null || _string == other._string || _string is null && other._string == "" || _string == "" && other._string is null) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(_int);
            hashcode.Add(real);
            hashcode.Add(_string);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

