using System;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSDistTriggerModifier Signatire: 0xb34d2bbd size: 128 flags: FLAGS_NONE

    // targetPosition class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // distance class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // distanceTrigger class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // trigger@event class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    public partial class BSDistTriggerModifier : hkbModifier, IEquatable<BSDistTriggerModifier?>
    {
        public Vector4 targetPosition { set; get; }
        public float distance { set; get; }
        public float distanceTrigger { set; get; }
        public hkb@eventProperty trigger@event { set; get; } = new();

        public override uint Signature { set; get; } = 0xb34d2bbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            targetPosition = br.ReadVector4();
            distance = br.ReadSingle();
            distanceTrigger = br.ReadSingle();
            trigger@event.Read(des, br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(targetPosition);
            bw.WriteSingle(distance);
            bw.WriteSingle(distanceTrigger);
            trigger@event.Write(s, bw);
            bw.Position += 8;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            targetPosition = xd.ReadVector4(xe, nameof(targetPosition));
            distance = xd.ReadSingle(xe, nameof(distance));
            distanceTrigger = xd.ReadSingle(xe, nameof(distanceTrigger));
            trigger@event = xd.ReadClass<hkb@eventProperty>(xe, nameof(trigger@event));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(targetPosition), targetPosition);
            xs.WriteFloat(xe, nameof(distance), distance);
            xs.WriteFloat(xe, nameof(distanceTrigger), distanceTrigger);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(trigger@event), trigger@event);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BSDistTriggerModifier);
        }

        public bool Equals(BSDistTriggerModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   targetPosition.Equals(other.targetPosition) &&
                   distance.Equals(other.distance) &&
                   distanceTrigger.Equals(other.distanceTrigger) &&
                   ((trigger@event is null && other.trigger@event is null) || (trigger@event is not null && other.trigger@event is not null && trigger@event.Equals((IHavokObject)other.trigger@event))) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(targetPosition);
            hashcode.Add(distance);
            hashcode.Add(distanceTrigger);
            hashcode.Add(trigger@event);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

