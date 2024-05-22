using System;

namespace _1._4_V10B
{
    internal class Program
    {
        public static double F(double x) => Math.Pow(x, 2) + 4 * Math.Sin(x);
        public static double F1(double x) => 2 * x + 4 * Math.Cos(x);
        public static double F2(double x) => 2 - 4 * Math.Sin(x);

        static void Main(string[] args)
        {


            double a, b, m, e, x;
            e = 0.000001;

            Console.WriteLine("Введите начало отрезка");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка");
            b = double.Parse(Console.ReadLine());

            if (F(a) * F(b) >= 0)
            {
                Console.WriteLine("Значение корня функции с точностью {0} равно {1}", e, F(a));
                Console.ReadKey();
                return;
            }
            m = Math.Min(F1(a), F1(b));
            Console.WriteLine("Параметр m равен {0}", m);
            if (F(a) * F2(a) > 0)
            {
                x = a;
            }
            else x = b;
            Console.WriteLine("Начальное приближение x: {0}", x);

            while (Math.Abs(F(x)) / m > e)
            {
                x = x - F(x) / F1(x);
                Console.WriteLine(x);
            }
            x = Math.Round(x, 5);
            Console.WriteLine("Значение корня функции с точностью {0} равно {1}", e, x);
            Console.ReadKey();
        }
    }
}
