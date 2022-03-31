using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace Task1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, MyClass.max(5,2));
            Assert.AreEqual(2.156, MyClass.max(2, 2.156));
            Assert.AreEqual(1.01, MyClass.max(1, 1.01));
            Assert.AreEqual(456123, MyClass.max(456123, 2));
            Assert.AreEqual(0.002, MyClass.max(0, 0.002));
            Assert.AreEqual(8, MyClass.max(7, 8));

            Assert.AreEqual(-7.2, MyClass.func(1.2, 2.3));
            Assert.AreEqual(-6, MyClass.func(1, 2));
            Assert.AreEqual(-36.75, MyClass.func(6.125, 7.125));
            Assert.AreEqual(0, MyClass.func(0, 0));
            Assert.AreEqual(-154, MyClass.func(-156, 2));
            Assert.AreEqual(1, MyClass.func(-1, -2));
        }
    }
}