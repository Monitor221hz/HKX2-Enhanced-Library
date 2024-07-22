using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbSenseHandleModifierRange Signatire: 0xfb56b692 size: 32 flags: FLAGS_NONE

    // @eventm_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_minDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_maxDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_ignoreHandle m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbSenseHandleModifierRange : IHavokObject, IEquatable<hkbSenseHandleModifierRange?>
    {
        public hkbEventProperty @event{ set; get; } = new();
        public float m_minDistance { set; get; }
        public float m_maxDistance { set; get; }
        public bool m_ignoreHandle { set; get; }

        public virtual uint Signature { set; get; } = 0xfb56b692;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            @event.Read(des, br);
            m_minDistance = br.ReadSingle();
            m_maxDistance = br.ReadSingle();
            m_ignoreHandle = br.ReadBoolean();
            br.Position += 7;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            @event.Write(s, bw);
            bw.WriteSingle(m_minDistance);
            bw.WriteSingle(m_maxDistance);
            bw.WriteBoolean(m_ignoreHandle);
            bw.Position += 7;
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            @event= xd.ReadClass<hkbEventProperty>(xe, nameof(@event));
            m_minDistance = xd.ReadSingle(xe, nameof(m_minDistance));
            m_maxDistance = xd.ReadSingle(xe, nameof(m_maxDistance));
            m_ignoreHandle = xd.ReadBoolean(xe, nameof(m_ignoreHandle));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteClass<hkbEventProperty>(xe, nameof(@event), @event);
            xs.WriteFloat(xe, nameof(m_minDistance), m_minDistance);
            xs.WriteFloat(xe, nameof(m_maxDistance), m_maxDistance);
            xs.WriteBoolean(xe, nameof(m_ignoreHandle), m_ignoreHandle);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbSenseHandleModifierRange);
        }

        public bool Equals(hkbSenseHandleModifierRange? other)
        {
            return other is not null &&
                   ((@event is null && other.@event is null) || (@event is not null && other.@event is not null && @event.Equals((IHavokObject)other.@event))) &&
                   m_minDistance.Equals(other.m_minDistance) &&
                   m_maxDistance.Equals(other.m_maxDistance) &&
                   m_ignoreHandle.Equals(other.m_ignoreHandle) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(@event);
            hashcode.Add(m_minDistance);
            hashcode.Add(m_maxDistance);
            hashcode.Add(m_ignoreHandle);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

