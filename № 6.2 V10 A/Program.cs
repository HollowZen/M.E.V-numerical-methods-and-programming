using System;

namespace __6._2_V10_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double x, y, f, g, k1, k2, k3, k4, h;
            x = 0;                  // Крайняя левая точка диапазона "х"
            y = 0;                 // Значение "у" в крайней левой точке
            h = 0.2;                // Шаг сетки "h"
            int t = 5;             // Округление до нужного знака, после запятой
            int n = 10;            // Количество итераций 
            double F(double a, double b) =>
                (1 + Math.Pow(Math.E, x)) * (1 + y);  // Заданная функция, где х=а, у=b

            for (int j = 1; j <= n; j++)
            {
                k1 = F(x, y);
                k2 = F(x + h / 2, y + (h * k1 / 2));
                k3 = F(x + h / 2, y + (h * k2 / 2));
                k4 = F(x + h, y + (h * k3));
                g = (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                y = (g + y);
                Console.WriteLine($"Коэф. к1: {Math.Round(k1, t)}");
                Console.WriteLine($"Коэф. к2: {Math.Round(k2, t)}");
                Console.WriteLine($"Коэф. к3: {Math.Round(k3, t)}");
                Console.WriteLine($"Коэф. к4: {Math.Round(k4, t)}");
                Console.WriteLine($"Значение <delta-y> в точке {j} : {Math.Round(g, t)}");
                Console.WriteLine($"Значение <y> в точке {j} : {Math.Round(y, t)}");
                x = x + h;
                if (j != n)
                    Console.WriteLine("Нажмите любую клавишу для продолжения вычислений...");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
