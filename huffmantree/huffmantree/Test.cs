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
		public void TestEncode2()
		{
			Encoder enc = new Encoder("");
			string result = enc.Encode();
		}

		[Test]
		public void TestEncode3()
		{
			Encoder enc = new Encoder(" ");
			string result = enc.Encode();
		}

		[Test]
		public void TestEncode4()
		{
			Encoder enc = new Encoder("skdajfksfdaksldfjdslkafjlkdsajflkdsajflkdsajflkdsajffdsjslkfdjslkaf");
			string result = enc.Encode();
		}

		[Test]
		public void TestEncode5()
		{
			Encoder enc = new Encoder("a");
			string result = enc.Encode();
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

        [Test]
        public void TestDecode2()
        {
            Encoder enc = new Encoder("Old Macdonald had a farm");
            enc.Encode();
            string result = enc.Decode();
            string expected = "Old Macdonald had a farm";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDecode3()
        {
            Encoder enc = new Encoder("\n \n \n");
            enc.Encode();
            string result = enc.Decode();
            string expected = "\n \n \n";

            Assert.AreEqual(expected, result);
        }
    }
}
