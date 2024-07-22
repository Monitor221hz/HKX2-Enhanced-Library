using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorGraphInternalStateInfo Signatire: 0x645f898b size: 80 flags: FLAGS_NONE

    // characterId class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // internalState class: hkbBehaviorGraphInternalState Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // auxiliaryNodeInfo class: hkbAuxiliaryNodeInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // active@eventIds class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // activeVariableIds class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkbBehaviorGraphInternalStateInfo : hkReferencedObject, IEquatable<hkbBehaviorGraphInternalStateInfo?>
    {
        public ulong characterId { set; get; }
        public hkbBehaviorGraphInternalState? internalState { set; get; }
        public IList<hkbAuxiliaryNodeInfo> auxiliaryNodeInfo { set; get; } = Array.Empty<hkbAuxiliaryNodeInfo>();
        public IList<short> active@eventIds { set; get; } = Array.Empty<short>();
        public IList<short> activeVariableIds { set; get; } = Array.Empty<short>();

        public override uint Signature { set; get; } = 0x645f898b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            characterId = br.ReadUInt64();
            internalState = des.ReadClassPointer<hkbBehaviorGraphInternalState>(br);
            auxiliaryNodeInfo = des.ReadClassPointerArray<hkbAuxiliaryNodeInfo>(br);
            active@eventIds = des.ReadInt16Array(br);
            activeVariableIds = des.ReadInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(characterId);
            s.WriteClassPointer(bw, internalState);
            s.WriteClassPointerArray(bw, auxiliaryNodeInfo);
            s.WriteInt16Array(bw, active@eventIds);
            s.WriteInt16Array(bw, activeVariableIds);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            characterId = xd.ReadUInt64(xe, nameof(characterId));
            internalState = xd.ReadClassPointer<hkbBehaviorGraphInternalState>(xe, nameof(internalState));
            auxiliaryNodeInfo = xd.ReadClassPointerArray<hkbAuxiliaryNodeInfo>(xe, nameof(auxiliaryNodeInfo));
            active@eventIds = xd.ReadInt16Array(xe, nameof(active@eventIds));
            activeVariableIds = xd.ReadInt16Array(xe, nameof(activeVariableIds));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(characterId), characterId);
            xs.WriteClassPointer(xe, nameof(internalState), internalState);
            xs.WriteClassPointerArray(xe, nameof(auxiliaryNodeInfo), auxiliaryNodeInfo);
            xs.WriteNumberArray(xe, nameof(active@eventIds), active@eventIds);
            xs.WriteNumberArray(xe, nameof(activeVariableIds), activeVariableIds);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbBehaviorGraphInternalStateInfo);
        }

        public bool Equals(hkbBehaviorGraphInternalStateInfo? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   characterId.Equals(other.characterId) &&
                   ((internalState is null && other.internalState is null) || (internalState is not null && other.internalState is not null && internalState.Equals((IHavokObject)other.internalState))) &&
                   auxiliaryNodeInfo.SequenceEqual(other.auxiliaryNodeInfo) &&
                   active@eventIds.SequenceEqual(other.active@eventIds) &&
                   activeVariableIds.SequenceEqual(other.activeVariableIds) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(characterId);
            hashcode.Add(internalState);
            hashcode.Add(auxiliaryNodeInfo.Aggregate(0, (x, y) => x ^ y?.GetHashCode() ?? 0));
            hashcode.Add(active@eventIds.Aggregate(0, (x, y) => x ^ y.GetHashCode()));
            hashcode.Add(activeVariableIds.Aggregate(0, (x, y) => x ^ y.GetHashCode()));
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

