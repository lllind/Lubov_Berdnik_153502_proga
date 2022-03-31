using System;
using task2.Services;

public class Task2
{
    public static double inputDouble()
    {
        while (true)
        {
            double n;

            if (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Повторите попытку!");
            }
            else
            {
                return n;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите a:");
        double a = inputDouble();

        Console.WriteLine("Введитe b:");
        double b = inputDouble();

        Console.WriteLine("Введите z:");
        double z = inputDouble();

        double y = MyClass.func(a,b,z);
        Console.WriteLine("y = " + y);
    }
}