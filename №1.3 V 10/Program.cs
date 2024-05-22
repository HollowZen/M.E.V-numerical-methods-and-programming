using System;

namespace _1._3_V_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F(double x) => ((8 * Math.Log(x)) + 8) / 5;

            double x1, x2;
            double e = 0.001;
            x1 = 1;
            Console.WriteLine("Первое приближение: {0}", x1);
            x2 = F(x1);
            while (Math.Abs(x1 - F(x1)) > e && x1 > 0)
            {
                x1 = x2;
                x2 = F(x1);

            };
            Console.WriteLine("Ответ: X = {0} ", Math.Round(x1, 3));
            Console.ReadKey();
        }
    }
}
