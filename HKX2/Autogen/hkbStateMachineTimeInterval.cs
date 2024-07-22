using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineTimeInterval Signatire: 0x60a881e5 size: 16 flags: FLAGS_NONE

    // enter@eventId class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // exit@eventId class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // enterTime class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // exitTime class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineTimeInterval : IHavokObject, IEquatable<hkbStateMachineTimeInterval?>
    {
        public int enter@eventId { set; get; }
        public int exit@eventId { set; get; }
        public float enterTime { set; get; }
        public float exitTime { set; get; }

        public virtual uint Signature { set; get; } = 0x60a881e5;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            enter@eventId = br.ReadInt32();
            exit@eventId = br.ReadInt32();
            enterTime = br.ReadSingle();
            exitTime = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(enter@eventId);
            bw.WriteInt32(exit@eventId);
            bw.WriteSingle(enterTime);
            bw.WriteSingle(exitTime);
        }

        public virtual void ReadXml(IXmlReader xd, XElement xe)
        {
            enter@eventId = xd.ReadInt32(xe, nameof(enter@eventId));
            exit@eventId = xd.ReadInt32(xe, nameof(exit@eventId));
            enterTime = xd.ReadSingle(xe, nameof(enterTime));
            exitTime = xd.ReadSingle(xe, nameof(exitTime));
        }

        public virtual void WriteXml(IXmlWriter xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(enter@eventId), enter@eventId);
            xs.WriteNumber(xe, nameof(exit@eventId), exit@eventId);
            xs.WriteFloat(xe, nameof(enterTime), enterTime);
            xs.WriteFloat(xe, nameof(exitTime), exitTime);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkbStateMachineTimeInterval);
        }

        public bool Equals(hkbStateMachineTimeInterval? other)
        {
            return other is not null &&
                   enter@eventId.Equals(other.enter@eventId) &&
                   exit@eventId.Equals(other.exit@eventId) &&
                   enterTime.Equals(other.enterTime) &&
                   exitTime.Equals(other.exitTime) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(enter@eventId);
            hashcode.Add(exit@eventId);
            hashcode.Add(enterTime);
            hashcode.Add(exitTime);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

