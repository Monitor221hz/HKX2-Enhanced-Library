using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbTimerModifier Signatire: 0x338b4879 size: 112 flags: FLAGS_NONE

    // alarmTimeSeconds class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // alarm@event class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // secondsElapsed class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbTimerModifier : hkbModifier, IEquatable<hkbTimerModifier?>
    {
        public float alarmTimeSeconds { set; get; }
        public hkb@eventProperty alarm@event { set; get; } = new();
        private float secondsElapsed { set; get; }

        public override uint Signature { set; get; } = 0x338b4879;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            alarmTimeSeconds = br.ReadSingle();
            br.Position += 4;
            alarm@event.Read(des, br);
            secondsElapsed = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(alarmTimeSeconds);
            bw.Position += 4;
            alarm@event.Write(s, bw);
            bw.WriteSingle(secondsElapsed);
            bw.Position += 4;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            alarmTimeSeconds = xd.ReadSingle(xe, nameof(alarmTimeSeconds));
            alarm@event = xd.ReadClass<hkb@eventProperty>(xe, nameof(alarm@event));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(alarmTimeSeconds), alarmTimeSeconds);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(alarm@event), alarm@event);
            xs.WriteSerializeIgnored(xe, nameof(secondsElapsed));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbTimerModifier);
        }

        public bool Equals(hkbTimerModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   alarmTimeSeconds.Equals(other.alarmTimeSeconds) &&
                   ((alarm@event is null && other.alarm@event is null) || (alarm@event is not null && other.alarm@event is not null && alarm@event.Equals((IHavokObject)other.alarm@event))) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(alarmTimeSeconds);
            hashcode.Add(alarm@event);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

