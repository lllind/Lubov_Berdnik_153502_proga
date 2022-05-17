using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        public bool CheckDouble(double left, double right)
        {
            return Math.Abs(left - right) < 1E-3;
        }
        GES a = GES.getInstance();

        [TestMethod]
        public void TestMethod1()
        {
            a.Residents = 1500;
            a.GESTariffOn();
            a.IncreaseGesTariff(5);
            a.Payment = 123;
            a.ResidentsPay = 1200;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(184500, ans));
        }

        [TestMethod]
        public void TestMethod2()
        {
            a.Residents = 5;
            a.GESTariffOn();
            a.DecreaseGesTariff(1);
            a.Payment = 1;
            a.ResidentsPay = 3;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(0, ans));
        }

        [TestMethod]
        public void TestMethod3()
        {
            a.Residents = 1500;
            a.GESTariffOn();
            a.IncreaseGesTariff(5);
            a.Payment = 123;
            a.ResidentsPay = 1200;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(0, ans));
        }

        [TestMethod]
        public void TestMethod4()
        {
            a.Residents = 1500;
            a.GESTariffOn();
            a.IncreaseGesTariff(5);
            a.Payment = 123;
            a.ResidentsPay = 1200;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(0, ans));
        }

        [TestMethod]
        public void TestMethod5()
        {
            a.Residents = 1500;
            a.GESTariffOn();
            a.IncreaseGesTariff(5);
            a.Payment = 123;
            a.ResidentsPay = 1200;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(0, ans));
        }

        [TestMethod]
        public void TestMethod6()
        {
            a.Residents = 1500;
            a.GESTariffOn();
            a.IncreaseGesTariff(5);
            a.Payment = 123;
            a.ResidentsPay = 1200;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(0, ans));
        }

        [TestMethod]
        public void TestMethod7()
        {
            a.Residents = 1500;
            a.GESTariffOn();
            a.IncreaseGesTariff(5);
            a.Payment = 123;
            a.ResidentsPay = 1200;
            double ans = a.Debt();
            Assert.IsTrue(CheckDouble(0, ans));
        }
    }
}