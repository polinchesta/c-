using System;

namespace job1
{   public class A
    {
        public int a;
        public int b;

        public double FuncCalc(int b)
        {
            return (Math.Pow(b, 10));
        }
        public double ZnachVyr(int b)
        {
            return (4 / (a + 2)) * b;

        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        static void Main(string[] vs)
        {
            Console.WriteLine("Enter numbers with enter: ");

            A a = new(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine($"Подсчёт степени { a.FuncCalc(a.b)}");
            Console.WriteLine($"Подсчёт выражения {a.ZnachVyr(a.b)}");
        }
    }
}