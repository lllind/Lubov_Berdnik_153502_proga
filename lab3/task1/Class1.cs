using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class MyClass
    {
        public static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static double func(double x, double y)
        {
            double z = max(x, 2 * y + x) - max(7 * x + 2 * y, y);
            return z;
        }
    }
}
