using System;
using System.Xml.Linq;

namespace HKX2
{
    // BSCyclicBlendTransitionGenerator Signatire: 0x5119eb06 size: 176 flags: FLAGS_NONE

    // pBlenderGenerator class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_16|FLAGS_NONE enum: 
    // @eventToFreezeBlendValue class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // @eventToCrossBlend class: hkb@eventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // fBlendParameter class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    // fTransitionDuration class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags: FLAGS_NONE enum: 
    // eBlendCurve class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 128 flags: FLAGS_NONE enum: BlendCurve
    // pTransitionBlenderGenerator class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|ALIGN_16|FLAGS_NONE enum: 
    // pTransitionEffect class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|ALIGN_16|FLAGS_NONE enum: 
    // currentMode class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 168 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSCyclicBlendTransitionGenerator : hkbGenerator, IEquatable<BSCyclicBlendTransitionGenerator?>
    {
        public hkbGenerator? pBlenderGenerator { set; get; }
        public hkb@eventProperty @eventToFreezeBlendValue { set; get; } = new();
        public hkb@eventProperty @eventToCrossBlend { set; get; } = new();
        public float fBlendParameter { set; get; }
        public float fTransitionDuration { set; get; }
        public sbyte eBlendCurve { set; get; }
        private object? pTransitionBlenderGenerator { set; get; }
        private object? pTransitionEffect { set; get; }
        private sbyte currentMode { set; get; }

        public override uint Signature { set; get; } = 0x5119eb06;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            pBlenderGenerator = des.ReadClassPointer<hkbGenerator>(br);
            @eventToFreezeBlendValue.Read(des, br);
            @eventToCrossBlend.Read(des, br);
            fBlendParameter = br.ReadSingle();
            fTransitionDuration = br.ReadSingle();
            eBlendCurve = br.ReadSByte();
            br.Position += 15;
            des.ReadEmptyPointer(br);
            br.Position += 8;
            des.ReadEmptyPointer(br);
            currentMode = br.ReadSByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, pBlenderGenerator);
            @eventToFreezeBlendValue.Write(s, bw);
            @eventToCrossBlend.Write(s, bw);
            bw.WriteSingle(fBlendParameter);
            bw.WriteSingle(fTransitionDuration);
            bw.WriteSByte(eBlendCurve);
            bw.Position += 15;
            s.WriteVoidPointer(bw);
            bw.Position += 8;
            s.WriteVoidPointer(bw);
            bw.WriteSByte(currentMode);
            bw.Position += 7;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            pBlenderGenerator = xd.ReadClassPointer<hkbGenerator>(xe, nameof(pBlenderGenerator));
            @eventToFreezeBlendValue = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToFreezeBlendValue));
            @eventToCrossBlend = xd.ReadClass<hkb@eventProperty>(xe, nameof(@eventToCrossBlend));
            fBlendParameter = xd.ReadSingle(xe, nameof(fBlendParameter));
            fTransitionDuration = xd.ReadSingle(xe, nameof(fTransitionDuration));
            eBlendCurve = xd.ReadFlag<BlendCurve, sbyte>(xe, nameof(eBlendCurve));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(pBlenderGenerator), pBlenderGenerator);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToFreezeBlendValue), @eventToFreezeBlendValue);
            xs.WriteClass<hkb@eventProperty>(xe, nameof(@eventToCrossBlend), @eventToCrossBlend);
            xs.WriteFloat(xe, nameof(fBlendParameter), fBlendParameter);
            xs.WriteFloat(xe, nameof(fTransitionDuration), fTransitionDuration);
            xs.WriteEnum<BlendCurve, sbyte>(xe, nameof(eBlendCurve), eBlendCurve);
            xs.WriteSerializeIgnored(xe, nameof(pTransitionBlenderGenerator));
            xs.WriteSerializeIgnored(xe, nameof(pTransitionEffect));
            xs.WriteSerializeIgnored(xe, nameof(currentMode));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BSCyclicBlendTransitionGenerator);
        }

        public bool Equals(BSCyclicBlendTransitionGenerator? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   ((pBlenderGenerator is null && other.pBlenderGenerator is null) || (pBlenderGenerator is not null && other.pBlenderGenerator is not null && pBlenderGenerator.Equals((IHavokObject)other.pBlenderGenerator))) &&
                   ((@eventToFreezeBlendValue is null && other.@eventToFreezeBlendValue is null) || (@eventToFreezeBlendValue is not null && other.@eventToFreezeBlendValue is not null && @eventToFreezeBlendValue.Equals((IHavokObject)other.@eventToFreezeBlendValue))) &&
                   ((@eventToCrossBlend is null && other.@eventToCrossBlend is null) || (@eventToCrossBlend is not null && other.@eventToCrossBlend is not null && @eventToCrossBlend.Equals((IHavokObject)other.@eventToCrossBlend))) &&
                   fBlendParameter.Equals(other.fBlendParameter) &&
                   fTransitionDuration.Equals(other.fTransitionDuration) &&
                   eBlendCurve.Equals(other.eBlendCurve) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(pBlenderGenerator);
            hashcode.Add(@eventToFreezeBlendValue);
            hashcode.Add(@eventToCrossBlend);
            hashcode.Add(fBlendParameter);
            hashcode.Add(fTransitionDuration);
            hashcode.Add(eBlendCurve);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

