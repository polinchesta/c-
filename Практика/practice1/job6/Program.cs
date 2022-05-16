using System;

namespace job6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double A = 0;
            const double B = Math.PI / 2;

            const int M = 10;
            const double ILength = 2.0;
            double y = 0;

            Console.Write("Input number Х: ");
            double x = double.Parse(Console.ReadLine());

            double H = (B - A) / M;
            for (double i = 0; i < ILength; i += 0.1)
            {
                y = x - Math.Sin(x);
                Console.WriteLine($"i= {Math.Round(i, 2)} | | y= {y}");
                x += H;
            }
            Console.ReadLine();
        }
    }
}
