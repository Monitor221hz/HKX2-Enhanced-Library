using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEvaluateExpressionModifierInternalExpressionData Signatire: 0xb8686f6b size: 2 flags: FLAGS_NONE

    // raised@event class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // wasTrueInPreviousFrame class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 1 flags: FLAGS_NONE enum: 
    public partial class hkbEvaluateExpressionModifierInternalExpressionData : IHavokObject, IEquatable<hkbEvaluateExpressionModifierInternalExpressionData?>
    {
        public bool raised@event { set; get; }
        public bool wasTrueInPreviousFrame { set; get; }

        public virtual uint Signature { set; get; } = 0xb8686f6b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            raised@event = br.ReadBoolean();
            wasTrueInPreviousFrame = br.ReadBoolean();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBoolean(raised@event);
            bw.WriteBoolean(wasTrueInPreviousFrame);
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            raised@event = xd.ReadBoolean(xe, nameof(raised@event));
            wasTrueInPreviousFrame = xd.ReadBoolean(xe, nameof(wasTrueInPreviousFrame));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteBoolean(xe, nameof(raised@event), raised@event);
            xs.WriteBoolean(xe, nameof(wasTrueInPreviousFrame), wasTrueInPreviousFrame);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbEvaluateExpressionModifierInternalExpressionData);
        }

        public bool Equals(hkbEvaluateExpressionModifierInternalExpressionData? other)
        {
            return other is not null &&
                   raised@event.Equals(other.raised@event) &&
                   wasTrueInPreviousFrame.Equals(other.wasTrueInPreviousFrame) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(raised@event);
            hashcode.Add(wasTrueInPreviousFrame);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

