using System;

namespace job1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                const double E = 2.71;
                double X;
                double Y = 0;

                Console.Write("Input Х: ");
                
                X = double.Parse(Console.ReadLine());

                if ((X >= 1) && (X <= 2))
                {
                    Y = Math.Sqrt(X) * Math.Log10(X) * 10;
                }
                else 
                if (X < 1)
                {
                    Y = 1;
                }
                else 
                if (X > 2)
                {
                    Y = Math.Pow(E, 2 * X) * Math.Cos(5 * X);
                }

                Console.WriteLine("Answer: " + Y);
                Console.ReadLine();
            }
        }

    }
