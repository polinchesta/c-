using System;

namespace job3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const double X = 5.2;
                double Y = Math.Pow(Math.Sin(Math.Pow(X * X + 5, 2)), 3) - Math.Pow(X / 4, 0.5);
                Console.Write("Answer: " + Y);
                Console.ReadLine();
            }

        }
    }
}
