using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehavior@eventsInfo Signatire: 0x66840004 size: 48 flags: FLAGS_NONE

    // characterId class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // external@eventIds class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // padding class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    public partial class hkbBehavior@eventsInfo : hkReferencedObject, IEquatable<hkbBehavior@eventsInfo?>
    {
        public ulong characterId { set; get; }
        public IList<short> external@eventIds { set; get; } = Array.Empty<short>();
        public int padding { set; get; }

        public override uint Signature { set; get; } = 0x66840004;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            characterId = br.ReadUInt64();
            external@eventIds = des.ReadInt16Array(br);
            padding = br.ReadInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(characterId);
            s.WriteInt16Array(bw, external@eventIds);
            bw.WriteInt32(padding);
            bw.Position += 4;
        }

        public override void ReadXml(IXmlReader xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            characterId = xd.ReadUInt64(xe, nameof(characterId));
            external@eventIds = xd.ReadInt16Array(xe, nameof(external@eventIds));
            padding = xd.ReadInt32(xe, nameof(padding));
        }

        public override void WriteXml(IXmlWriter xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(characterId), characterId);
            xs.WriteNumberArray(xe, nameof(external@eventIds), external@eventIds);
            xs.WriteNumber(xe, nameof(padding), padding);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbBehavior@eventsInfo);
        }

        public bool Equals(hkbBehavior@eventsInfo? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   characterId.Equals(other.characterId) &&
                   external@eventIds.SequenceEqual(other.external@eventIds) &&
                   padding.Equals(other.padding) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(characterId);
            hashcode.Add(external@eventIds.Aggregate(0, (x, y) => x ^ y.GetHashCode()));
            hashcode.Add(padding);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

