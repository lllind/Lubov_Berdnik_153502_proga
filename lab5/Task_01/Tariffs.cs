using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    public class Tariffs
    {

        private static int[] priceList = new int[5];
        public enum Tariff : int
        {
            Russia,
            Poland,
            Africa,
            Australia,
            USA
        }
        
        public void SetTariff(Tariff tariff, int num) {
            priceList[((int)tariff)] = num;
        }

        public static int GetTariff(Tariff tariff)
        {
            return priceList[((int)tariff)];
        }
    }
}