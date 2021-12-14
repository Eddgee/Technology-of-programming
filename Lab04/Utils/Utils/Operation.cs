using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Operation
    {
        public static bool Area(double a, double b, double c, out double res)
        {
            bool ok = true;  // true если треугольник существует и наоборот
            if (Exists(a, b, c))
            {
                double p = (a + b + c) / 2;  // вычисляем полупериметр
                res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                ok = false;
                res = -1;
            }
            return ok;
        }

        private static bool Exists(double a, double b, double c)
        {
            if (Math.Max(a, Math.Max(b, c)) < a + b + c - Math.Max(a, Math.Max(b, c)))
                return true;
            else
                return false;
        }

        public static bool Area(double a, out double res)
        {
            double p = a * 3 / 2;  // вычисляем полупериметр
            res = Math.Sqrt(p * Math.Pow((p - a), 3));
            return true;
        }

        public static int Roots(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;
            double d = b * b - 4 * a * c; // дискриминант квадратного уравнения

            if (d < 0)        // нет корней
                return -1;
            else if (d == 0)  // один корень
            {
                x1 = -b / 2 / a;
                x2 = x1;
                return 0;
            }
            else              // два корня
            {
                x1 = (-b - Math.Sqrt(d)) / 2 / a;
                x2 = (-b + Math.Sqrt(d)) / 2 / a;
                return 1;
            }
        }
    }
}
