using Xunit;
using System;

namespace Task_01
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Airport airport = Airport.Creating();
            Assert.Equal(0, airport.Sold_Seats());
            airport.ChangeTar(Tariffs.Tariff.Africa, 50);
            airport.EnterData("Nam", "Surn", 222, Tariffs.Tariff.Africa);
            Assert.Equal(50, airport.Sold_Seats());
            airport.ChangeTar(Tariffs.Tariff.Australia, 70);
            airport.EnterData("Alex", "B", 585, Tariffs.Tariff.Australia);
            airport.EnterData("Nam", "Surn", 222, Tariffs.Tariff.Australia);
            Assert.Equal(190, airport.Sold_Seats());
            PersonalData dat = new PersonalData("Nam", "Surn", 222);
            Assert.Equal(120, airport.GetUserPrice(dat));
        }
    }
}