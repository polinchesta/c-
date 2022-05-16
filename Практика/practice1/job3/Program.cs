using System;

namespace job3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Enter Ball= ");
                byte ball = byte.Parse(Console.ReadLine());
                if (ball <= 100 && ball >= 90)
                    Console.WriteLine("Отлично");
                else
                    if (ball >= 70 && ball <= 48)
                    Console.WriteLine("Хорошо");
                else
                        if (ball >= 50 && ball <= 69)
                    Console.WriteLine("Удовлетворительно");
                else
                    Console.WriteLine("Неудовлетворительно");
                Console.ReadKey(true);
            }
        }
    }
    }
