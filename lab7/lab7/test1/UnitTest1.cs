using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            matrix matrix = new matrix(5, 6, 3, 3);
            Assert.AreEqual(-3, matrix.GetDeter());
        }

        [TestMethod]
        public void TestMethod2()
        {
            matrix matrix = new matrix(5, 6, 3, 3);
            matrix.SetDeter(56);

            Assert.AreEqual(56, matrix.GetDeter());
        }

        [TestMethod]
        public void TestMethod3()
        {
            matrix matrix = new matrix(5, 6, 3, 3);
            matrix matrix2 = new matrix(5, 6, 3, 3);
            matrix res = new matrix(10, 12, 6, 6);
            bool result = false;
            if (matrix + matrix2 == res)
                result = true;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            matrix matrix = new matrix(12, 45, 67, 4);
            matrix matrix2 = new matrix(5, 6, 3, 3);
            matrix res = new matrix(7, 39, 64, 1);
            bool result = false;
            if (matrix - matrix2 == res)
                result = true;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            matrix matrix = new matrix(12, 45, 67, 4);
            matrix matrix2 = new matrix(5, 6, 3, 3);
            matrix res = new matrix(195, 207, 347, 414);
            bool result = false;
            if (matrix * matrix2 == res)
                result = true;

            Assert.IsTrue(result);
        }
    }
}