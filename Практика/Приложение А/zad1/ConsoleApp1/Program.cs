using System;

namespace job2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a four-digit number: ");
            int Number = int.Parse(Console.ReadLine());
            int SecondNumber = Number / 1000 * 100 + Number / 100 % 10 * 1000 + Number % 100;
            Console.WriteLine("Numbers = " + SecondNumber);
        }
    }
}
