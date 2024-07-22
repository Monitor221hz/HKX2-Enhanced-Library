using System.Xml.Linq;

namespace HKX2
{
    public interface IHavokObject
    {
        public uint Signature { set; get; }

        public void Read(PackFileDeserializer des, BinaryReaderEx br);

        public void Write(PackFileSerializer s, BinaryWriterEx bw);
        public void WriteXml(IXmlWriter xs, XElement xe);
        public void ReadXml(IXmlReader xd, XElement xe);
    }
}