using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // BSRagdollContactListenerModifier Signatire: 0x8003d8ce size: 136 flags: FLAGS_NONE

    // contact@event class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // bones class: hkbBoneIndexArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // throw@event class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // ragdollRigidBodies class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSRagdollContactListenerModifier : hkbModifier, IEquatable<BSRagdollContactListenerModifier?>
    {
        public hkb@eventProperty contact@event { set; get; } = new();
        public hkbBoneIndexArray? bones { set; get; }
        private bool throw@event { set; get; }
        public IList<object> ragdollRigidBodies { set; get; } = Array.Empty<object>();

        public override uint Signature { set; get; } = 0x8003d8ce;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            contact@event.Read(des, br);
            bones = des.ReadClassPointer<hkbBoneIndexArray>(br);
            throw@event = br.ReadBoolean();
            br.Position += 7;
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            contact@event.Write(s, bw);
            s.WriteClassPointer(bw, bones);
            bw.WriteBoolean(throw@event);
            bw.Position += 7;
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            contact@event = xd.ReadClass<hkb@eventProperty>(xe, nameof(contact@event));
            bones = xd.ReadClassPointer<hkbBoneIndexArray>(xe, nameof(bones));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(contact@event), contact@event);
            xs.WriteClassPointer(xe, nameof(bones), bones);
            xs.WriteSerializeIgnored(xe, nameof(throw@event));
            xs.WriteSerializeIgnored(xe, nameof(ragdollRigidBodies));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BSRagdollContactListenerModifier);
        }

        public bool Equals(BSRagdollContactListenerModifier? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   ((contact@event is null && other.contact@event is null) || (contact@event is not null && other.contact@event is not null && contact@event.Equals((IHavokObject)other.contact@event))) &&
                   ((bones is null && other.bones is null) || (bones is not null && other.bones is not null && bones.Equals((IHavokObject)other.bones))) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(contact@event);
            hashcode.Add(bones);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

