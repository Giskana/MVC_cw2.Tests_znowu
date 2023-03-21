using mvc_2.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVC_cw2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrimaryTest()
        {
            PrimalGenerator pg = new PrimalGenerator();
            Assert.IsTrue(pg.IsPrimal(3));
        }

        [TestMethod]
        public void IsPrimaryTest2()
        {
            PrimalGenerator pg = new PrimalGenerator();
            Assert.IsFalse(pg.IsPrimal(4));
        }

        [TestMethod]
        public void IsPrimaryListTest()
        {
            PrimalGenerator pgGenerator = new PrimalGenerator();
            var primals = pgGenerator.GetPrimals(10);
            Assert.AreEqual(4,primals.Count);
        }

        [TestMethod]
        public void IsPrimaryListTest20()
        {
            PrimalGenerator pgGenerator = new PrimalGenerator();
            var primals = pgGenerator.GetPrimals(20);
            Assert.AreEqual(primals.Last(), 19);
        }
    }
}