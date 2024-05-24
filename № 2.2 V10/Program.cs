using System;

namespace __2._2_V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            const int n = 4; //размерность системы
            double[,] a = new double[n, n];
            double[] b = new double[n];
            double[] x = new double[n];

            for (int i = 0; i < n; i++)

                x[i] = 0;
            Console.WriteLine("Введите построчно коэффициенты системы: x1, x2, x3, x4");

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine());
                }

            Console.WriteLine("Введите свободные коэффициенты: y1, y2, y3, y4");
            for (int i = 0; i < n; i++) b[i] = double.Parse(Console.ReadLine());

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
                    }
                    b[i] = b[i] - b[k] * a[i, k] / a[k, k];
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + a[k, j] * x[j];
                x[k] = (b[k] - s) / a[k, k];
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Система имеет следующие корни");
                Console.WriteLine("x1 = {0:0.##}", x[i]);
                i++;
                Console.WriteLine("x2 = {0:0.##}", x[i]);
                i++;
                Console.WriteLine("x3 = {0:0.##}", x[i]);
                i++;
                Console.WriteLine("x4 = {0:0.##}", x[i]);
                i++;

            }
            Console.ReadKey();
        }
    }
}
