using System;
using task3;

public class Task3
{
    public static bool inputDate(string date)
    {
        while (true)
        {
            if (!DateTime.TryParse(date, out DateTime n))
            {
                Console.WriteLine("Ошибка ввода! Повторите попытку!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите дату:");
        string d = Console.ReadLine();
        while (!inputDate(d))
        {
            Console.Write("Enter the date: ");
            d = Console.ReadLine();
        }

        DateTime date = DateTime.Parse(d);
        Console.WriteLine("День недели: " + DateService.GetDay(date));

        Console.WriteLine("Количество дней между текущей датой и датой, веденной пользователем: " +
        DateService.GetDaysSpan(date.Day, date.Month, date.Year));
    }
}