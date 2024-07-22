using System;
using System.Xml.Linq;

namespace HKX2
{
    // BS@eventEveryN@eventsModifier Signatire: 0x6030970c size: 128 flags: FLAGS_NONE

    // @eventToCheckFor class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // @eventToSend class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // numberOf@eventsBeforeSend class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // minimumNumberOf@eventsBeforeSend class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 113 flags: FLAGS_NONE enum: 
    // randomizeNumberOf@events class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 114 flags: FLAGS_NONE enum: 
    // numberOf@eventsSeen class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 116 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // calculatedNumberOf@eventsBeforeSend class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BS@eventEveryN@eventsModifier : hkbModifier, IEquatable<BS@eventEveryN@eventsModifier?>
    {
        public hkb@eventProperty @eventToCheckFor { set; get; } = new();
        public hkb@eventProperty @eventToSend { set; get; } = new();
        public sbyte numberOf@eventsBeforeSend { set; get; }
        public sbyte minimumNumberOf@eventsBeforeSend { set; get; }
        public bool randomizeNumberOf@events { set; get; }
        private int numberOf@eventsSeen { set; get; }
        private sbyte calculatedNumberOf@eventsBeforeSend { set; get; }

        public override uint Signature { set; get; } = 0x6030970c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            @eventToCheckFor.Read(des, br);
            @eventToSend.Read(des, br);
            numberOf@eventsBeforeSend = br.ReadSByte();
            minimumNumberOf@eventsBeforeSend = br.ReadSByte();
            randomizeNumberOf@events = br.ReadBoolean();
            br.Position += 1;
            numberOf@eventsSeen = br.ReadInt32();
            calculatedNumberOf@eventsBeforeSend = br.ReadSByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            @eventToCheckFor.Write(s, bw);
            @eventToSend.Write(s, bw);
            bw.WriteSByte(numberOf@eventsBeforeSend);
            bw.WriteSByte(minimumNumberOf@eventsBeforeSend);
            bw.WriteBoolean(randomizeNumberOf@events);
            bw.Position += 1;
            bw.WriteInt32(numberOf@eventsSeen);
            bw.WriteSByte(calculatedNumberOf@eventsBeforeSend);
            bw.Position += 7;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            @eventToCheckFor = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToCheckFor));
            @eventToSend = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToSend));
            numberOf@eventsBeforeSend = xd.ReadSByte(xe, nameof(numberOf@eventsBeforeSend));
            minimumNumberOf@eventsBeforeSend = xd.ReadSByte(xe, nameof(minimumNumberOf@eventsBeforeSend));
            randomizeNumberOf@events = xd.ReadBoolean(xe, nameof(randomizeNumberOf@events));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToCheckFor), @eventToCheckFor);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToSend), @eventToSend);
            xs.WriteNumber(xe, nameof(numberOf@eventsBeforeSend), numberOf@eventsBeforeSend);
            xs.WriteNumber(xe, nameof(minimumNumberOf@eventsBeforeSend), minimumNumberOf@eventsBeforeSend);
            xs.WriteBoolean(xe, nameof(randomizeNumberOf@events), randomizeNumberOf@events);
            xs.WriteSerializeIgnored(xe, nameof(numberOf@eventsSeen));
            xs.WriteSerializeIgnored(xe, nameof(calculatedNumberOf@eventsBeforeSend));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BS@eventEveryN@eventsModifier);
        }

        public bool Equals(BS@eventEveryN@eventsModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   ((@eventToCheckFor is null && other.@eventToCheckFor is null) || (@eventToCheckFor is not null && other.@eventToCheckFor is not null && @eventToCheckFor.Equals((IHavokObject)other.@eventToCheckFor))) &&
                   ((@eventToSend is null && other.@eventToSend is null) || (@eventToSend is not null && other.@eventToSend is not null && @eventToSend.Equals((IHavokObject)other.@eventToSend))) &&
                   numberOf@eventsBeforeSend.Equals(other.numberOf@eventsBeforeSend) &&
                   minimumNumberOf@eventsBeforeSend.Equals(other.minimumNumberOf@eventsBeforeSend) &&
                   randomizeNumberOf@events.Equals(other.randomizeNumberOf@events) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(@eventToCheckFor);
            hashcode.Add(@eventToSend);
            hashcode.Add(numberOf@eventsBeforeSend);
            hashcode.Add(minimumNumberOf@eventsBeforeSend);
            hashcode.Add(randomizeNumberOf@events);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

