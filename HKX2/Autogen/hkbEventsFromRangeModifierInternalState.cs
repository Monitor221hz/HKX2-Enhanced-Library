using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HKX2
{
    // hkb@eventsFromRangeModifierInternalState Signatire: 0xcc47b48d size: 32 flags: FLAGS_NONE

    // wasActiveInPreviousFrame class:  Type.TYPE_ARRAY Type.TYPE_BOOL arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkb@eventsFromRangeModifierInternalState : hkReferencedObject, IEquatable<hkb@eventsFromRangeModifierInternalState?>
    {
        public IList<bool> wasActiveInPreviousFrame { set; get; } = Array.Empty<bool>();

        public override uint Signature { set; get; } = 0xcc47b48d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            wasActiveInPreviousFrame = des.ReadBooleanArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteBooleanArray(bw, wasActiveInPreviousFrame);
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            wasActiveInPreviousFrame = xd.ReadBooleanArray(xe, nameof(wasActiveInPreviousFrame));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBooleanArray(xe, nameof(wasActiveInPreviousFrame), wasActiveInPreviousFrame);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkb@eventsFromRangeModifierInternalState);
        }

        public bool Equals(hkb@eventsFromRangeModifierInternalState? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   wasActiveInPreviousFrame.SequenceEqual(other.wasActiveInPreviousFrame) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(wasActiveInPreviousFrame.Aggregate(0, (x, y) => x ^ y.GetHashCode()));
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

