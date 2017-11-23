using NUnit.Framework;

namespace huffmantree
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestEncode()
        {
            Encoder enc = new Encoder("hello world");
            string result = enc.Encode();
            string expected = "00000110101100100111101110101111";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDecode()
        {
            Encoder enc = new Encoder("hello world");
            enc.Encode();
            string result = enc.Decode();
            string expected = "hello world";

            Assert.AreEqual(expected, result);
        }
    }
}