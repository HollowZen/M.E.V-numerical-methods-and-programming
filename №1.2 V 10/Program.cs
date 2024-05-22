using System;

namespace _1._2_V_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F(double x) => Math.Pow(x, 2) * Math.Pow(2, x) - 1;
            double a, b, c;
            double e = 0.01;
            Console.WriteLine("Уравнение F(x)=x^2 * 2^x - 1");
            Console.WriteLine("Введите начало отрезка");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка");
            b = double.Parse(Console.ReadLine());
            while (b - a > 2 * e)
            {
                c = (a + b) / 2;
                if (F(a) * F(c) > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
            }
            Console.WriteLine("ЗНАЧЕНИЕ КОРНЯ С ТОЧНОСТЬЮ {0} РАВНО {1}", e, (a + b) / 2);
            Console.ReadKey();
        }


    }
}
