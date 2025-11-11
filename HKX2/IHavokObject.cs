using System.Xml.Linq;

namespace HKX2E
{
    public interface IHavokObject
    {
        public uint Signature { set; get; }

        public void Read(PackFileDeserializer des, BinaryReaderEx br);

        public void Write(PackFileSerializer s, BinaryWriterEx bw);
        public void WriteXml(IHavokXmlWriter xs, XElement xe);
        public void ReadXml(IHavokXmlReader xd, XElement xe);
        public void WriteMetaData(PackFileSerializer s, BinaryWriterEx bw, ulong metaData)
        {
            bw.Pad(8);
        }
        public ulong ReadMetaData(PackFileDeserializer s, BinaryReaderEx br)
        {
            br.Pad(8);
            return 0;
        }
    }
}
