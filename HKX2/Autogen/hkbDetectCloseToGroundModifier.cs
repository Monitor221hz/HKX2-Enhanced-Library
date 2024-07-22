using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbDetectCloseToGroundModifier Signatire: 0x981687b2 size: 120 flags: FLAGS_NONE

    // closeToGround@event class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // closeToGroundHeight class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // raycastDistanceDown class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // collisionFilterInfo class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // boneIndex class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    // animBoneIndex class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 110 flags: FLAGS_NONE enum: 
    // isCloseToGround class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbDetectCloseToGroundModifier : hkbModifier, IEquatable<hkbDetectCloseToGroundModifier?>
    {
        public hkb@eventProperty closeToGround@event { set; get; } = new();
        public float closeToGroundHeight { set; get; }
        public float raycastDistanceDown { set; get; }
        public uint collisionFilterInfo { set; get; }
        public short boneIndex { set; get; }
        public short animBoneIndex { set; get; }
        private bool isCloseToGround { set; get; }

        public override uint Signature { set; get; } = 0x981687b2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            closeToGround@event.Read(des, br);
            closeToGroundHeight = br.ReadSingle();
            raycastDistanceDown = br.ReadSingle();
            collisionFilterInfo = br.ReadUInt32();
            boneIndex = br.ReadInt16();
            animBoneIndex = br.ReadInt16();
            isCloseToGround = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            closeToGround@event.Write(s, bw);
            bw.WriteSingle(closeToGroundHeight);
            bw.WriteSingle(raycastDistanceDown);
            bw.WriteUInt32(collisionFilterInfo);
            bw.WriteInt16(boneIndex);
            bw.WriteInt16(animBoneIndex);
            bw.WriteBoolean(isCloseToGround);
            bw.Position += 7;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            closeToGround@event = xd.ReadClass<hkb@eventProperty>(xe, nameof(closeToGround@event));
            closeToGroundHeight = xd.ReadSingle(xe, nameof(closeToGroundHeight));
            raycastDistanceDown = xd.ReadSingle(xe, nameof(raycastDistanceDown));
            collisionFilterInfo = xd.ReadUInt32(xe, nameof(collisionFilterInfo));
            boneIndex = xd.ReadInt16(xe, nameof(boneIndex));
            animBoneIndex = xd.ReadInt16(xe, nameof(animBoneIndex));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(closeToGround@event), closeToGround@event);
            xs.WriteFloat(xe, nameof(closeToGroundHeight), closeToGroundHeight);
            xs.WriteFloat(xe, nameof(raycastDistanceDown), raycastDistanceDown);
            xs.WriteNumber(xe, nameof(collisionFilterInfo), collisionFilterInfo);
            xs.WriteNumber(xe, nameof(boneIndex), boneIndex);
            xs.WriteNumber(xe, nameof(animBoneIndex), animBoneIndex);
            xs.WriteSerializeIgnored(xe, nameof(isCloseToGround));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbDetectCloseToGroundModifier);
        }

        public bool Equals(hkbDetectCloseToGroundModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   ((closeToGround@event is null && other.closeToGround@event is null) || (closeToGround@event is not null && other.closeToGround@event is not null && closeToGround@event.Equals((IHavokObject)other.closeToGround@event))) &&
                   closeToGroundHeight.Equals(other.closeToGroundHeight) &&
                   raycastDistanceDown.Equals(other.raycastDistanceDown) &&
                   collisionFilterInfo.Equals(other.collisionFilterInfo) &&
                   boneIndex.Equals(other.boneIndex) &&
                   animBoneIndex.Equals(other.animBoneIndex) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(closeToGround@event);
            hashcode.Add(closeToGroundHeight);
            hashcode.Add(raycastDistanceDown);
            hashcode.Add(collisionFilterInfo);
            hashcode.Add(boneIndex);
            hashcode.Add(animBoneIndex);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

