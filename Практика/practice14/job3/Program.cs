using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace job3
{
    internal class Program
    {
        
        static void First(int A)
        {
            double sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum = sum + Math.Pow(A, i);
                Console.WriteLine($" {sum} ");
            }
        }
        static void Second(double A)
        {
            double umn = 1;
            for (int j = 1; j < 10; j++)
            {
                umn = umn * Math.Pow(A, j);
                Console.WriteLine($" {umn} ");
            }
        }
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Input A: ");
            A = Convert.ToInt32(Console.ReadLine());
            int N;
            Console.WriteLine("Input N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Thread thread1 = new Thread(() => First(A));
            Thread thread2 = new Thread(() => Second(N));
            Stopwatch time = new Stopwatch();
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }

}



