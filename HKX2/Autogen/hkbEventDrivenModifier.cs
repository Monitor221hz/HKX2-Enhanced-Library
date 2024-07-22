using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkb@eventDrivenModifier Signatire: 0x7ed3f44e size: 104 flags: FLAGS_NONE

    // activate@eventId class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // deactivate@eventId class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // activeByDefault class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // isActive class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 97 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkb@eventDrivenModifier : hkbModifierWrapper, IEquatable<hkb@eventDrivenModifier?>
    {
        public int activate@eventId { set; get; }
        public int deactivate@eventId { set; get; }
        public bool activeByDefault { set; get; }
        private bool isActive { set; get; }

        public override uint Signature { set; get; } = 0x7ed3f44e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            activate@eventId = br.ReadInt32();
            deactivate@eventId = br.ReadInt32();
            activeByDefault = br.ReadBoolean();
            isActive = br.ReadBoolean();
            br.Position += 6;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(activate@eventId);
            bw.WriteInt32(deactivate@eventId);
            bw.WriteBoolean(activeByDefault);
            bw.WriteBoolean(isActive);
            bw.Position += 6;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            activate@eventId = xd.ReadInt32(xe, nameof(activate@eventId));
            deactivate@eventId = xd.ReadInt32(xe, nameof(deactivate@eventId));
            activeByDefault = xd.ReadBoolean(xe, nameof(activeByDefault));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(activate@eventId), activate@eventId);
            xs.WriteNumber(xe, nameof(deactivate@eventId), deactivate@eventId);
            xs.WriteBoolean(xe, nameof(activeByDefault), activeByDefault);
            xs.WriteSerializeIgnored(xe, nameof(isActive));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkb@eventDrivenModifier);
        }

        public bool Equals(hkb@eventDrivenModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   activate@eventId.Equals(other.activate@eventId) &&
                   deactivate@eventId.Equals(other.deactivate@eventId) &&
                   activeByDefault.Equals(other.activeByDefault) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(activate@eventId);
            hashcode.Add(deactivate@eventId);
            hashcode.Add(activeByDefault);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

