using System;

namespace job1
{
    internal class Program
    {
            static double Y1(double x)
            {
                return 4 - ( x - 7 / 4-x);
            }
            static double Y2(double x)
            {
                return Math.Sin(x) / (Math.Pow(x, 3) - 1);
            }
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Input х1: ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Function result Y1:" + Y1(x1));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                try
                {
                    Console.Write("Input х2: ");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    if (Double.IsNaN(Y2(x2)))
                    {
                        Console.WriteLine("Not a number.");
                    }
                    else
                    {
                        Console.WriteLine("Function result Y2:" + Y2(x2));
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                Console.ReadLine();
            }
        }
    }
    

