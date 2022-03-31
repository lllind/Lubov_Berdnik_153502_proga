using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2.Services;

namespace Task2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, MyClass.func(1, 0, 2));
            Assert.AreEqual(0.17620165414812683, MyClass.func(8, 9, 1));
            Assert.AreEqual(0.1, MyClass.func(0.1, 0, 0.1));
            Assert.AreEqual(98.97189509834394, MyClass.func(56, -12, 2));
            Assert.AreEqual(-0.8467674352893799, MyClass.func(-2, -1, -2));
            Assert.AreEqual(0.9715207154302776, MyClass.func(1, 1, 1));
        }
    }
}