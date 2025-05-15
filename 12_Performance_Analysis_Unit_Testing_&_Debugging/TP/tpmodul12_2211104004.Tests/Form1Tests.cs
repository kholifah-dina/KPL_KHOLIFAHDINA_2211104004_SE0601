using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2211104004;

namespace tpmodul12_2211104004.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Test_CariTandaBilangan_Negatif()
        {
            // Arrange
            var form = new Form1();

            // Act
            string result = form.CariTandaBilangan(-5);

            // Assert
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void Test_CariTandaBilangan_Positif()
        {
            var form = new Form1();
            string result = form.CariTandaBilangan(7);
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void Test_CariTandaBilangan_Nol()
        {
            var form = new Form1();
            string result = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", result);
        }
    }
}
