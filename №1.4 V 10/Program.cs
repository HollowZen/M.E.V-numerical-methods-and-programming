using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_V_10
{
    internal class Program
    {
        public static double F(double x) => Math.Pow(x,3)-3*Math.Pow(x,2) + 12*x - 9;
        public static double F1(double x)=>3*(Math.Pow(x, 2)) -6*x+12;
        public static double F2(double x) => 6 * (x - 1);

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
                Console.WriteLine("Не удволетворяет первое условие F(a) * F(b) >= 0");
                return;
            }
            m = Math.Min(F1(a), F1(b));
            Console.WriteLine("Параметр m равен {0}", m);
            if (F(a) * F2(a) > 0)
            {
                x = a;
            }
            else x = b;
            Console.WriteLine("Начальное приближение x: {0}",x);

            while (Math.Abs(F(x)) / m > e) {
                x = x - F(x)/F1(x);
                Console.WriteLine(x);
            }
            x = Math.Round(x, 5);
            Console.WriteLine("Значение корня функции с точностью {0} равно {1}",e,x);
            Console.ReadKey();
        }
    }
}
