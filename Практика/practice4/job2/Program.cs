using System;

namespace job2
{
    internal class Program
    {
        
      
            static double F(double x)
            {
                if ((-1 < x) && (x < 1))
                {
                    return x + 14;
                }
                else if (-1 <= x)
                {
                    return x - 1  / x - 4;
                }
                else
                {
                    throw new IndexOutOfRangeException("OUT OF RANGE!");
                }
            }
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Input X: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Function result:" + F(x));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                catch (IndexOutOfRangeException dx)
                {
                    Console.WriteLine(dx.Message);
                }
                Console.ReadLine();
            }
        }
    }
    

