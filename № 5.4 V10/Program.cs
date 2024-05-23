using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __5._4_V10
{
    internal class Program
    {
        const double e = Math.E;
        public static double F(double x) => Math.Sqrt(x)/(x+1);




        static void Main(string[] args)
        {

            double a, b, x, h, s;
            int n;
            Random random = new Random();

            Console.WriteLine("Введите начало промежутка");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N");
            n = int.Parse(Console.ReadLine());

            h = (b - a) / n;
            s = 0;
            for (int i = 1; i < n; i++)
            {
                x = a + (b - a) * random.NextDouble();
                s = s + F(x) * h;

            }
            Console.WriteLine("ЗНАЧЕНИЕ ИНТЕГРАЛА {0}", Math.Round(s, 5));
            Console.ReadKey();


        }
    }
}
