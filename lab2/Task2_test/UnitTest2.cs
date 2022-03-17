using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2_test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Solving.solve(0, 15), 0);
            Assert.AreEqual(Solving.solve(1, 15), -1);
            Assert.AreEqual(Solving.solve(15, 4), -1);
            Assert.AreEqual(Solving.solve(4, 6), 1);
            Assert.AreEqual(Solving.solve(0, -15), -1);
            Assert.AreEqual(Solving.solve(2, 13), 1);
            Assert.AreEqual(Solving.solve(0, 0), 0);
            Assert.AreEqual(Solving.solve(1, 1), 0);
            Assert.AreEqual(Solving.solve(-10, 10), 0);
        }
    }
}