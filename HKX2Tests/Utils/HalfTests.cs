using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HKX2E.Tests
{
    // Due to the `hkHalf` specification, the `Half` binary data handled by this library does not conform to IEEE 754,
    // so write/read tests must be performed.
    [TestClass]
    public class HalfTests
    {
        enum Endianness
        {
            Little,
            Big,
        }

        void AssertHalf(double from, byte[] expected, double to, Endianness endian)
        {
            var isBigEndian = Endianness.Big == endian;
            var stream = new MemoryStream();
            var bw = new BinaryWriterEx(isBigEndian, true, stream);
            bw.WriteHalf((Half)from);

            stream.Seek(0, SeekOrigin.Begin);

            var bytes = stream.ToArray();
            CollectionAssert.AreEqual(expected, bytes);

            var br = new BinaryReaderEx(isBigEndian, true, stream);
            var result = br.ReadHalf();
            Assert.AreEqual((float)to, (float)result);
        }

        [TestMethod]
        public void HalfToLEBytes()
        {
            // Use the value that actually appears.
            // "Skyrim Special Edition\meshes\actors\wisp\character assets\skeleton.hkx"
            // 00006090: 8e 49 24 41 00 00 4c 3d 80 3f 7f 7f 02 00 00 00  .I$A..L=.?......
            //                                   |----| <- m_timeFactor: 1.000000
            //                             |----| <- angularDamping: 0.498046875
            //
            //angularDamping: 0x3d4c0000
            // -> float: 0.498046875 -> 0.049804688(The precision will be lost)
            // -> ToXML: 0.049805(The sixth decimal point is rounded off, resulting in a loss of precision)

            AssertHalf(1.0, [0x80, 0x3F], 1.0, Endianness.Little);
            AssertHalf(0.049805, [0x4c, 0x3d], 0.049804688, Endianness.Little);
        }

        [TestMethod]
        public void HalfToBEBytes()
        {
            AssertHalf(1.0, [0x3F, 0x80], 1.0, Endianness.Big);
            AssertHalf(0.049805, [0x3d, 0x4c], 0.049804688, Endianness.Big);
        }
    }
}
