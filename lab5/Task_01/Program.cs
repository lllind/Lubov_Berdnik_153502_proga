using System;

namespace Task_01
{
    public class Lab_04
    {

        public static bool checkUp(string input)
        {
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("invalid value, try again");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void TarChange()
        {
            Console.WriteLine("\t\t1 - Russia\t\t2 - Poland\t\t3 - Africa\t\t4 - Australia\t\t5 - USA");
            var tar_choice = int.Parse(Console.ReadLine()) - 1;
            Tariffs.Tariff tar = (Tariffs.Tariff)tar_choice;
            Console.WriteLine("Enter new price of this direction: ");
            int newCost = int.Parse(Console.ReadLine());
            Airport airport = Airport.Creating();
            airport.ChangeTar(tar, newCost);
        }

        public static void BuyTicket()
        {
            Airport airport = Airport.Creating();
            Console.WriteLine("Enter your name: ");
            string nam = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surn = Console.ReadLine();
            Console.WriteLine("Enter your passport number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Which country are you willing to visit: 1 - Russia\n\t\t2 - Poland\n\t\t3 - Africa\n\t\t4 - Australia\n\t\t5 - USA");
            int num_tar = int.Parse(Console.ReadLine()) - 1;
            Tariffs.Tariff tarrr = (Tariffs.Tariff)num_tar;
            airport.EnterData(nam, surn, num, tarrr);
        }

        public static void UserPrice()
        {
            Console.WriteLine("Enter your name: ");
            string nam = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surn = Console.ReadLine();
            Console.WriteLine("Enter your passport number: ");
            int num = int.Parse(Console.ReadLine());
            PersonalData dat = new PersonalData(nam, surn, num);
            Airport airport = Airport.Creating();
            int res = airport.GetUserPrice(dat);
            Console.WriteLine("Total cost is: " + res);
        }

        public static void TotalPrice()
        {
            Airport airport = Airport.Creating();
            int res = airport.Sold_Seats();
            Console.WriteLine("Total price of seld tickets: " + res);
        }

        static void Main(string[] args)
        {
            int choice = 1;
            Airport airport = Airport.Creating();
            while (choice != 0)
            {
                Console.WriteLine("\nEnter:\t0 - Exit\n\t1 - Change the list of tariffs\n\t2 - Buy a ticket\n\t3 - " +
                    "Count total price of user\n\t4 - Count the total amount of sold tickets");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    TarChange();
                }
                else if (choice == 2)
                {
                    BuyTicket();
                }
                else if(choice == 3)
                {
                    UserPrice();
                }
                else
                {
                    TotalPrice();
                }
            }
        }
    }
}