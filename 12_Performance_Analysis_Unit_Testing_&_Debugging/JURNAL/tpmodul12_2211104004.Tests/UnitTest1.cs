using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_2211104004;
using tpmodul12_2211104004; // Ganti sesuai nama project kamu

namespace tpmodul12_2211104004.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Test_BEqualsZero_Returns1()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(10, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_BLessThanZero_ReturnsNegative1()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(5, -3);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test_BGreaterThan10_ReturnsNegative2()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(5, 11);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Test_AGreaterThan100_ReturnsNegative2()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(101, 3);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Test_ValidInput_ReturnsCorrectPower()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(2, 3); // 2^3 = 8
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Test_Overflow_ReturnsNegative3()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(10, 10); // 10^10 overflows int
            Assert.AreEqual(-3, result);
        }
    }
}
