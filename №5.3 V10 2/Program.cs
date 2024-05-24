using System;

namespace _5._3_V10_2
{
    internal class Program
    {
        public static double F(double x, double a) => 1 / (Math.Sqrt(Math.Pow(x, 2) + a));

        static double SimpsonIntegral(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = F(a, a) + F(b, a);

            for (int i = 1; i < n; i += 2)
            {
                sum += 4 * F(a, a + i * h);
            }

            for (int i = 2; i < n - 1; i += 2)
            {
                sum += 2 * F(a, a + i * h);
            }

            return sum * h / 3;
        }


        static void Main(string[] args)
        {

            double a, b, x, h, s;
            int i, n;
            ///
            ////////Переспросить
            ///
            Console.WriteLine("Введите начало промежутка");
            a = double.Parse(Console.ReadLine());
            b = double.PositiveInfinity;
            Console.WriteLine("Rонец промежутка {0}", b);
            Console.WriteLine("Введите N");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("ЗНАЧЕНИЕ ИНТЕГРАЛА {0}", Math.Round(SimpsonIntegral(a, b, n), 5));
            Console.ReadKey();


        }
    }
}
