using System;
using System.Xml.Linq;

namespace HKX2E
{
    // hkbEventSequencedDataSequencedEvent Signatire: 0x9139b821 size: 32 flags: FLAGS_NONE

    // eventclass: hkbEvent Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // time class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbEventSequencedDataSequencedEvent : IHavokObject, IEquatable<hkbEventSequencedDataSequencedEvent?>
    {
        public hkbEvent _event{ set; get; } = new();
        public float time { set; get; }

        public virtual uint Signature { set; get; } = 0x9139b821;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            _event.Read(des, br);
            time = br.ReadSingle();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            _event.Write(s, bw);
            bw.WriteSingle(time);
            bw.Position += 4;
        }

        public virtual void ReadXml(IHavokXmlReader xd, XElement xe)
        {
            _event= xd.ReadClass<hkbEvent>(xe, LITERAL.EVENT);
            time = xd.ReadSingle(xe, nameof(time));
        }

        public virtual void WriteXml(IHavokXmlWriter xs, XElement xe)
        {
            xs.WriteClass<hkbEvent>(xe, LITERAL.EVENT, _event);
            xs.WriteFloat(xe, nameof(time), time);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbEventSequencedDataSequencedEvent);
        }

        public bool Equals(hkbEventSequencedDataSequencedEvent? other)
        {
            return other is not null &&
                   ((_event is null && other._event is null) || (_event is not null && other._event is not null && _event.Equals((IHavokObject)other._event))) &&
                   time.Equals(other.time) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(_event);
            hashcode.Add(time);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

