using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3;
using System;

namespace Task3_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDayTest1()
        {
            DateTime d = new DateTime(2003, 10, 17);
            Assert.AreEqual(DateService.GetDay(d), DayOfWeek.Friday);
        }

        public void GetDayTest2()
        {
            DateTime d = new DateTime(2022, 03, 28);
            Assert.AreEqual(DateService.GetDay(d), DayOfWeek.Monday);
        }

        public void GetDayTest3()
        {
            DateTime d = new DateTime(2022, 03, 29);
            Assert.AreEqual(DateService.GetDay(d), DayOfWeek.Tuesday);
        }

        public void GetDayTest4()
        {
            DateTime d = new DateTime(2022, 03, 30);
            Assert.AreEqual(DateService.GetDay(d), DayOfWeek.Wednesday);
        }

        public void GetDayTest5()
        {
            DateTime d = new DateTime(2022, 03, 31);
            Assert.AreEqual(DateService.GetDay(d), DayOfWeek.Thursday);
        }

        public void GetDayTest6()
        {
            DateTime d = new DateTime(2022, 04, 01);
            Assert.AreEqual(DateService.GetDay(d), DayOfWeek.Friday);
        }

        public void SpanTest1()
        {
            Assert.AreEqual(DateService.GetDaysSpan(31, 3, 2022), 0);
            Assert.AreEqual(DateService.GetDaysSpan(30, 3, 2022), 1);
        }
    }
}