using System;

namespace prilA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Input B: ");
            double B = double.Parse(Console.ReadLine());
            double X = 0;
            X = (A + B) / 2;
            Console.WriteLine("half-sum = " + "{0:f3}", X);
            Console.ReadLine();

        }
    }
}
