using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventSequencedDataSequencedEvent Signatire: 0x9139b821 size: 32 flags: FLAGS_NONE

    // @eventm_class: hkbEvent Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbEventSequencedDataSequencedEvent : IHavokObject, IEquatable<hkbEventSequencedDataSequencedEvent?>
    {
        public hkbEvent @event{ set; get; } = new();
        public float m_time { set; get; }

        public virtual uint Signature { set; get; } = 0x9139b821;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            @event.Read(des, br);
            m_time = br.ReadSingle();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            @event.Write(s, bw);
            bw.WriteSingle(m_time);
            bw.Position += 4;
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            @event= xd.ReadClass<hkbEvent>(xe, nameof(@event));
            m_time = xd.ReadSingle(xe, nameof(m_time));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteClass<hkbEvent>(xe, nameof(@event), @event);
            xs.WriteFloat(xe, nameof(m_time), m_time);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbEventSequencedDataSequencedEvent);
        }

        public bool Equals(hkbEventSequencedDataSequencedEvent? other)
        {
            return other is not null &&
                   ((@event is null && other.@event is null) || (@event is not null && other.@event is not null && @event.Equals((IHavokObject)other.@event))) &&
                   m_time.Equals(other.m_time) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(@event);
            hashcode.Add(m_time);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

