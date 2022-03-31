using System;
using task1;

public class Task1
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
        Console.WriteLine("Введите x:");
        double x = inputDouble();

        Console.WriteLine("Введите y:");
        double y = inputDouble();

        double z = MyClass.func(x, y);
        Console.WriteLine("z = " + z);
    }
}