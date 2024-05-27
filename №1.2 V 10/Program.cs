using System;

namespace _1._2_V_10
{
    internal class Program
    {
        static double F(double x) => Math.Pow(x, 2) * Math.Pow(2, x) - 1;

        static double BisectionMethod(double a, double b, double e)
        {
            double c = (a + b) / 2;
            while ((b - a) / 2 > e)
            {

                if (F(c) == 0.0)
                    return c;

                if (F(a) * F(c) < 0)
                    b = c;
                else
                    a = c;

                c = (a + b) / 2;
            }
            return c;
        }

        static void Main()
        {
            double a = -1;
            double b = 1;
            double e = 0.01;

            // Локализация корня
            while (F(a) * F(b) > 0)
            {
                if (a > 0)
                {
                    a -= 1;
                }
                else
                {
                    b += 1;
                }
            }

            double x = BisectionMethod(a, b, e);
            Console.WriteLine($"Значение корня с заданной точностью e = {e}, равно {x}");
            Console.ReadKey();
        }


    }
}
