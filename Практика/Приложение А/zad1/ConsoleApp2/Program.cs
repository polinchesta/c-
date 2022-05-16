using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Input number: ");
            int V = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number: ");
            int V1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number: ");
            int t1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number: ");
            int t2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number: ");

            int S = (((V * t1) + t2)* (V - V1));
            Console.WriteLine("Путь = " + S);
        }
    }
}
        
