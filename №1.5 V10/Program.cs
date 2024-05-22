using System;

namespace _1._5_V10
{
    internal class Program
    {
        public static double F(double x)=> Math.Sqrt(1+Math.Pow(x,2))-(2*x);
        public static double F1(double x) => -(x/(Math.Pow(1-Math.Pow(x,2), 1 / 2)))-2;
        public static double F2(double x) => -(1 / (Math.Pow(1 - Math.Pow(x, 2), 3 / 2)));

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
            m = Math.Min(Math.Abs(F1(a)), Math.Abs(F1(b)));
            if (F(a) * F2(a) > 0)
            {
                x = a;
            }
            else x = b;
            Console.WriteLine("Начальное приближение x: {0}", x);

            if (x == b)
            {
                b = a;
                a = x;
            }
            while (Math.Abs(F(x)) / m > e)
            { 
               x=  x - F(x) / (F(x) - F(b)) * (x - b); ;

                Console.WriteLine(x);
                Console.WriteLine("////////",F(x));
            }
            Console.WriteLine("Значение корня функции с точностью {0} равно {1}", e, x);
            Console.WriteLine("Значение функции F(X) = {0}", F(x),5);
            Console.ReadKey();

        }
    }
}
