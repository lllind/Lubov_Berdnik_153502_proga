using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    public class Airport
    {
        private static Airport? airport = null;
        public List<PersonalData> personalData;

        Ticket ticket;
        Tariffs tariffs;

        private Airport()
        {
            tariffs = new Tariffs();
            personalData = new List<PersonalData>();
        }

        public static Airport Creating()
        {
            if (airport == null) airport = new Airport();
            return airport;
        }

        public void ChangeTar(Tariffs.Tariff tariff, int neueKost)
        {
            tariffs.SetTariff(tariff, neueKost);
        }

        public void EnterData(string nam, string surname, int num, Tariffs.Tariff tar)
        {
            PersonalData k = new PersonalData(nam, surname, num);
            k.Taris = tar;
            personalData.Add(k);
        }

        public int GetUserPrice(PersonalData dat)
        {
            int sum = 0;
            for (int i = 0; i < personalData.Count; ++i)
            {
                if (dat.Name == personalData[i].Name && dat.Surname == personalData[i].Surname &&
                    dat.NumberOfThePassport == personalData[i].NumberOfThePassport)
                {
                    sum += Tariffs.GetTariff(personalData[i].Taris);
                }
            }
            return sum;
        }

        public int Sold_Seats()
        {
            int sum = 0;
            for (int i = 0; i < personalData.Count; ++i)
            {
                sum += Tariffs.GetTariff(personalData[i].Taris);
            }
            return sum;
        }
    }
}