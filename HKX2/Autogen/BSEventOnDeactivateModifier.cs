using System;
using System.Xml.Linq;

namespace HKX2
{
    // BS@eventOnDeactivateModifier Signatire: 0x1062d993 size: 96 flags: FLAGS_NONE

    // @event class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class BS@eventOnDeactivateModifier : hkbModifier, IEquatable<BS@eventOnDeactivateModifier?>
    {
        public hkb@eventProperty @event { set; get; } = new();

        public override uint Signature { set; get; } = 0x1062d993;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            @event.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            @event.Write(s, bw);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            @event = xd.ReadClass<hkb@eventProperty>(xe, nameof(@event));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@event), @event);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BS@eventOnDeactivateModifier);
        }

        public bool Equals(BS@eventOnDeactivateModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   ((@event is null && other.@event is null) || (@event is not null && other.@event is not null && @event.Equals((IHavokObject)other.@event))) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(@event);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

