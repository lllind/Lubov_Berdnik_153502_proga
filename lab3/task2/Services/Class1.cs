using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Services
{
    public class MyClass
    {
        public static double func(double a, double b, double z)
        {
            double x, y;
            if (z < a*b)
            {
                Console.WriteLine("Ветка #1");
                x = Math.Pow(a * a + b * b * z, 1/2);
            }
            else
            {
                Console.WriteLine("Ветка #2");
                x = Math.Sin(z) * Math.Sin(z) + Math.Abs(a * b * z);
            }
            if (x+a*b == 0)
            {
                Console.WriteLine("В знаменателе 0");
            }
            y = (a * x + b * x * Math.Cos(Math.Pow(x, 1 / 2))) / (x + a * b);
            return y;
        }
    }
}
