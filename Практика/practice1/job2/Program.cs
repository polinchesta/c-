using System;

namespace job2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maximum value for two different real numbers");
            Console.Write("Input first number: ");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            double max;
            if (FirstNumber > SecondNumber)
            {
                max = FirstNumber;

            }
            else
            {
                max = SecondNumber;
            }
            Console.WriteLine("Max Number :{0}", max);

        }
    }
}
