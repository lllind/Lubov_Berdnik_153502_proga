using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    public class PersonalData
    {
        public PersonalData(string n, string surn, int numb)
        {
            Name = n;
            Surname = surn;
            NumberOfThePassport = numb;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int NumberOfThePassport { get; set; }

        public Tariffs.Tariff Taris { get; set; }
    }
}