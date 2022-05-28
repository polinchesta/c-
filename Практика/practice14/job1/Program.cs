using System;
using System.Threading;

namespace job1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread Thread1 = new Thread(First_Thread);
            Thread Thread2 = new Thread(Second_Thread);
            Thread Thread3 = new Thread(Third_Thread);

            Thread1.Priority = ThreadPriority.Highest;
            Thread2.Priority = ThreadPriority.Normal;
            Thread3.Priority = ThreadPriority.Lowest;


            Thread1.Start();
            Thread1.Join();
            Thread2.Start();
            Thread2.Join();
            Thread3.Start();
        }
        static void First_Thread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(20);
                Console.WriteLine("Вывод первого потока: " +i);
            }
        }
        static void Second_Thread()
        {
            for (int i = 10; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Вывод второго потока: "+ i);
            }

        }
        static void Third_Thread()
        {
            for (int i = 20; i < 30; i++)
            {
                Thread.Sleep(90);
                Console.WriteLine("Вывод третьего потока: " +i);
            }
        }
    }
}





