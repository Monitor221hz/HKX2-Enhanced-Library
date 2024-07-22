using System;
using System.Xml.Linq;

namespace HKX2
{
    // BS@eventOnFalseToTrueModifier Signatire: 0x81d0777a size: 160 flags: FLAGS_NONE

    // bEnable@event1 class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // bVariableToTest1 class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 81 flags: FLAGS_NONE enum: 
    // @eventToSend1 class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // bEnable@event2 class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // bVariableToTest2 class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 105 flags: FLAGS_NONE enum: 
    // @eventToSend2 class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // bEnable@event3 class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // bVariableToTest3 class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 129 flags: FLAGS_NONE enum: 
    // @eventToSend3 class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // bSlot1ActivatedLastFrame class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 152 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // bSlot2ActivatedLastFrame class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 153 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // bSlot3ActivatedLastFrame class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 154 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BS@eventOnFalseToTrueModifier : hkbModifier, IEquatable<BS@eventOnFalseToTrueModifier?>
    {
        public bool bEnable@event1 { set; get; }
        public bool bVariableToTest1 { set; get; }
        public hkb@eventProperty @eventToSend1 { set; get; } = new();
        public bool bEnable@event2 { set; get; }
        public bool bVariableToTest2 { set; get; }
        public hkb@eventProperty @eventToSend2 { set; get; } = new();
        public bool bEnable@event3 { set; get; }
        public bool bVariableToTest3 { set; get; }
        public hkb@eventProperty @eventToSend3 { set; get; } = new();
        private bool bSlot1ActivatedLastFrame { set; get; }
        private bool bSlot2ActivatedLastFrame { set; get; }
        private bool bSlot3ActivatedLastFrame { set; get; }

        public override uint Signature { set; get; } = 0x81d0777a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            bEnable@event1 = br.ReadBoolean();
            bVariableToTest1 = br.ReadBoolean();
            br.Position += 6;
            @eventToSend1.Read(des, br);
            bEnable@event2 = br.ReadBoolean();
            bVariableToTest2 = br.ReadBoolean();
            br.Position += 6;
            @eventToSend2.Read(des, br);
            bEnable@event3 = br.ReadBoolean();
            bVariableToTest3 = br.ReadBoolean();
            br.Position += 6;
            @eventToSend3.Read(des, br);
            bSlot1ActivatedLastFrame = br.ReadBoolean();
            bSlot2ActivatedLastFrame = br.ReadBoolean();
            bSlot3ActivatedLastFrame = br.ReadBoolean();
            br.Position += 5;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(bEnable@event1);
            bw.WriteBoolean(bVariableToTest1);
            bw.Position += 6;
            @eventToSend1.Write(s, bw);
            bw.WriteBoolean(bEnable@event2);
            bw.WriteBoolean(bVariableToTest2);
            bw.Position += 6;
            @eventToSend2.Write(s, bw);
            bw.WriteBoolean(bEnable@event3);
            bw.WriteBoolean(bVariableToTest3);
            bw.Position += 6;
            @eventToSend3.Write(s, bw);
            bw.WriteBoolean(bSlot1ActivatedLastFrame);
            bw.WriteBoolean(bSlot2ActivatedLastFrame);
            bw.WriteBoolean(bSlot3ActivatedLastFrame);
            bw.Position += 5;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            bEnable@event1 = xd.ReadBoolean(xe, nameof(bEnable@event1));
            bVariableToTest1 = xd.ReadBoolean(xe, nameof(bVariableToTest1));
            @eventToSend1 = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToSend1));
            bEnable@event2 = xd.ReadBoolean(xe, nameof(bEnable@event2));
            bVariableToTest2 = xd.ReadBoolean(xe, nameof(bVariableToTest2));
            @eventToSend2 = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToSend2));
            bEnable@event3 = xd.ReadBoolean(xe, nameof(bEnable@event3));
            bVariableToTest3 = xd.ReadBoolean(xe, nameof(bVariableToTest3));
            @eventToSend3 = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToSend3));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(bEnable@event1), bEnable@event1);
            xs.WriteBoolean(xe, nameof(bVariableToTest1), bVariableToTest1);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToSend1), @eventToSend1);
            xs.WriteBoolean(xe, nameof(bEnable@event2), bEnable@event2);
            xs.WriteBoolean(xe, nameof(bVariableToTest2), bVariableToTest2);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToSend2), @eventToSend2);
            xs.WriteBoolean(xe, nameof(bEnable@event3), bEnable@event3);
            xs.WriteBoolean(xe, nameof(bVariableToTest3), bVariableToTest3);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToSend3), @eventToSend3);
            xs.WriteSerializeIgnored(xe, nameof(bSlot1ActivatedLastFrame));
            xs.WriteSerializeIgnored(xe, nameof(bSlot2ActivatedLastFrame));
            xs.WriteSerializeIgnored(xe, nameof(bSlot3ActivatedLastFrame));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BS@eventOnFalseToTrueModifier);
        }

        public bool Equals(BS@eventOnFalseToTrueModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   bEnable@event1.Equals(other.bEnable@event1) &&
                   bVariableToTest1.Equals(other.bVariableToTest1) &&
                   ((@eventToSend1 is null && other.@eventToSend1 is null) || (@eventToSend1 is not null && other.@eventToSend1 is not null && @eventToSend1.Equals((IHavokObject)other.@eventToSend1))) &&
                   bEnable@event2.Equals(other.bEnable@event2) &&
                   bVariableToTest2.Equals(other.bVariableToTest2) &&
                   ((@eventToSend2 is null && other.@eventToSend2 is null) || (@eventToSend2 is not null && other.@eventToSend2 is not null && @eventToSend2.Equals((IHavokObject)other.@eventToSend2))) &&
                   bEnable@event3.Equals(other.bEnable@event3) &&
                   bVariableToTest3.Equals(other.bVariableToTest3) &&
                   ((@eventToSend3 is null && other.@eventToSend3 is null) || (@eventToSend3 is not null && other.@eventToSend3 is not null && @eventToSend3.Equals((IHavokObject)other.@eventToSend3))) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(bEnable@event1);
            hashcode.Add(bVariableToTest1);
            hashcode.Add(@eventToSend1);
            hashcode.Add(bEnable@event2);
            hashcode.Add(bVariableToTest2);
            hashcode.Add(@eventToSend2);
            hashcode.Add(bEnable@event3);
            hashcode.Add(bVariableToTest3);
            hashcode.Add(@eventToSend3);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

