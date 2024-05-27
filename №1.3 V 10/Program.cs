using System;

namespace _1._3_V_10
{
    internal class Program
    {
        static double F(double x) => 5 * x - 8 * Math.Log(x) - 8;
        static double g(double x) => (8 * Math.Log(x) + 8) / 5; // x = (8*lnx + 8)/5

        static double IterationMethod(double a, double e)
        {
            double x0 = a;
            double x1 = g(x0);

            while (Math.Abs(x1 - x0) > e && x1 > 0)
            {
                Console.WriteLine(x0);
                x0 = x1;
                x1 = g(x0);
            }
            return x1;
        }

        static void Main(string[] args)
        {
            double a = 2;   // начальная точка, a>0 
            double e = 0.001;

            double x = IterationMethod(a, e);
            Console.WriteLine($"Ответ: X = {x}");
            Console.ReadKey();
        }
    }
}
