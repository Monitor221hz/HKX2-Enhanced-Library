using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventRangeData Signatire: 0x6cb92c76 size: 32 flags: FLAGS_NONE

    // m_upperBound m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // @eventm_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: EventRangeMode
    public partial class hkbEventRangeData : IHavokObject, IEquatable<hkbEventRangeData?>
    {
        public float m_upperBound { set; get; }
        public hkbEventProperty @event{ set; get; } = new();
        public sbyte m_eventMode { set; get; }

        public virtual uint Signature { set; get; } = 0x6cb92c76;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_upperBound = br.ReadSingle();
            br.Position += 4;
            @event.Read(des, br);
            m_eventMode = br.ReadSByte();
            br.Position += 7;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_upperBound);
            bw.Position += 4;
            @event.Write(s, bw);
            bw.WriteSByte(m_eventMode);
            bw.Position += 7;
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            m_upperBound = xd.ReadSingle(xe, nameof(m_upperBound));
            @event= xd.ReadClass<hkbEventProperty>(xe, nameof(@event));
            m_eventMode = xd.ReadFlag<EventRangeMode, sbyte>(xe, nameof(m_eventMode));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_upperBound), m_upperBound);
            xs.WriteClass<hkbEventProperty>(xe, nameof(@event), @event);
            xs.WriteEnum<EventRangeMode, sbyte>(xe, nameof(m_eventMode), m_eventMode);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbEventRangeData);
        }

        public bool Equals(hkbEventRangeData? other)
        {
            return other is not null &&
                   m_upperBound.Equals(other.m_upperBound) &&
                   ((@event is null && other.@event is null) || (@event is not null && other.@event is not null && @event.Equals((IHavokObject)other.@event))) &&
                   m_eventMode.Equals(other.m_eventMode) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(m_upperBound);
            hashcode.Add(@event);
            hashcode.Add(m_eventMode);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

