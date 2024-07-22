using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbExpressionData Signatire: 0x6740042a size: 24 flags: FLAGS_NONE

    // expression class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // assignmentVariableIndex class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // assignment@eventIndex class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // @eventMode class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: Expression@eventMode
    // raised@event class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 17 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // wasTrueInPreviousFrame class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 18 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbExpressionData : IHavokObject, IEquatable<hkbExpressionData?>
    {
        public string expression { set; get; } = "";
        public int assignmentVariableIndex { set; get; }
        public int assignment@eventIndex { set; get; }
        public sbyte @eventMode { set; get; }
        private bool raised@event { set; get; }
        private bool wasTrueInPreviousFrame { set; get; }

        public virtual uint Signature { set; get; } = 0x6740042a;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            expression = des.ReadStringPointer(br);
            assignmentVariableIndex = br.ReadInt32();
            assignment@eventIndex = br.ReadInt32();
            @eventMode = br.ReadSByte();
            raised@event = br.ReadBoolean();
            wasTrueInPreviousFrame = br.ReadBoolean();
            br.Position += 5;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, expression);
            bw.WriteInt32(assignmentVariableIndex);
            bw.WriteInt32(assignment@eventIndex);
            bw.WriteSByte(@eventMode);
            bw.WriteBoolean(raised@event);
            bw.WriteBoolean(wasTrueInPreviousFrame);
            bw.Position += 5;
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            expression = xd.ReadString(xe, nameof(expression));
            assignmentVariableIndex = xd.ReadInt32(xe, nameof(assignmentVariableIndex));
            assignment@eventIndex = xd.ReadInt32(xe, nameof(assignment@eventIndex));
            @eventMode = xd.ReadFlag<Expression@eventMode, sbyte>(xe, nameof(@eventMode));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteString(xe, nameof(expression), expression);
            xs.WriteNumber(xe, nameof(assignmentVariableIndex), assignmentVariableIndex);
            xs.WriteNumber(xe, nameof(assignment@eventIndex), assignment@eventIndex);
            xs.WriteEnum<Expression@eventMode, sbyte>(xe, nameof(@eventMode), @eventMode);
            xs.WriteSerializeIgnored(xe, nameof(raised@event));
            xs.WriteSerializeIgnored(xe, nameof(wasTrueInPreviousFrame));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbExpressionData);
        }

        public bool Equals(hkbExpressionData? other)
        {
            return other is not null &&
                   (expression is null && other.expression is null || expression == other.expression || expression is null && other.expression == "" || expression == "" && other.expression is null) &&
                   assignmentVariableIndex.Equals(other.assignmentVariableIndex) &&
                   assignment@eventIndex.Equals(other.assignment@eventIndex) &&
                   @eventMode.Equals(other.@eventMode) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(expression);
            hashcode.Add(assignmentVariableIndex);
            hashcode.Add(assignment@eventIndex);
            hashcode.Add(@eventMode);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

