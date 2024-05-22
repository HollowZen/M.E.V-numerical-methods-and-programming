using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_V10
{
    internal class Program
    {
        const double e = Math.E;
        public static double F(double x, double a) => Math.Pow(e, a * x);



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
            
            Console.WriteLine("Введите начало промежутка");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("ЗНАЧЕНИЕ ИНТЕГРАЛА {0}", SimpsonIntegral(a,b,n));
            Console.ReadKey();


        }
    }
}
