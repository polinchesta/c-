using System;

namespace job3
{
    internal class Program
    {


        public static void DigitCountSum(int k, out int c, out int s)
        {
            c = 0;
            s = 0;
            while (k != 0)
            {
                s += k % 10;
                ++c;
                k /= 10;
            }

        }
         static void Main(string[] args)
         {
             try
             {
                 for (int i = 0; i < 5; i++)
                 {
                    int k;
                    Console.Write("k: ");
                    k = int.Parse(Console.ReadLine());
                    DigitCountSum(k, out int c, out int s);
                    Console.WriteLine("s: " + s);
                    Console.WriteLine("Number {0} to the power of 3= {1}", k, c, s);
                 }
                 Console.WriteLine("Program completed, press enter to exit.");
             }

             catch (FormatException ex)
             {
                Console.WriteLine(ex.Message, ex.StackTrace);
             }
                Console.ReadLine();
            }
        }
    }
    

