using System;

namespace job5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int SecondNumber;

            Console.Write("Enter a number , such that (1<=n<=10): ");
            Number = int.Parse(Console.ReadLine());

            int X = Number * Number;
            Console.Write(X);
            for (int i = 1; i < Number; i++)
            {
                SecondNumber = Number + i;
                X = X + (SecondNumber * SecondNumber);
            }
            Console.WriteLine(X);
            Console.ReadLine();
        }
    }
    }

