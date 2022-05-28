using System;
using System.Threading;
using System.Threading.Tasks;

namespace job2
{
    internal class Program
    {
        static void Sum()
        {
            int sum = 0;
            for (int i = 0; i <= 10; i++) 
            { sum += i; }
            Console.WriteLine($"Сумма чисел:{sum} ");
        }
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            swatch.Start();

            ThreadStart thread1 = new ThreadStart(Sum);
            Thread thread2 = new Thread(thread1);

            thread2.Start();
            swatch.Stop();

            Console.WriteLine("Время, потраченное на выполнение задачи: {0}", swatch.Elapsed);
            Console.ReadLine();
        }
    }
}

