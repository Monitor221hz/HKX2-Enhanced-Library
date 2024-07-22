using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkb@eventSequencedDataSequenced@event Signatire: 0x9139b821 size: 32 flags: FLAGS_NONE

    // @event class: hkb@event Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // time class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkb@eventSequencedDataSequenced@event : IHavokObject, IEquatable<hkb@eventSequencedDataSequenced@event?>
    {
        public hkb@event @event { set; get; } = new();
        public float time { set; get; }

        public virtual uint Signature { set; get; } = 0x9139b821;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            @event.Read(des, br);
            time = br.ReadSingle();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            @event.Write(s, bw);
            bw.WriteSingle(time);
            bw.Position += 4;
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            @event = xd.ReadClass<hkb@event>(xe, nameof(@event));
            time = xd.ReadSingle(xe, nameof(time));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteClass<hkb@event>(xe, nameof(@event), @event);
            xs.WriteFloat(xe, nameof(time), time);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkb@eventSequencedDataSequenced@event);
        }

        public bool Equals(hkb@eventSequencedDataSequenced@event? other)
        {
            return other is not null &&
                   ((@event is null && other.@event is null) || (@event is not null && other.@event is not null && @event.Equals((IHavokObject)other.@event))) &&
                   time.Equals(other.time) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(@event);
            hashcode.Add(time);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

