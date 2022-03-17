using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Solving.isEven(64));
            Assert.AreEqual(false, Solving.isEven(12));
            Assert.AreEqual(false, Solving.isEven(45));
            Assert.AreEqual(true, Solving.isEven(44));
            Assert.AreEqual(true, Solving.isEven(84));
            Assert.AreEqual(false, Solving.isEven(10));
            Assert.AreEqual(true, Solving.isEven(91));
            Assert.AreEqual(true, Solving.isEven(99));
            Assert.AreEqual(false, Solving.isEven(56));
            Assert.AreEqual(false, Solving.isEven(41));
        }
    }
}