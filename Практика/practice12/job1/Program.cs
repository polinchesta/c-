using System;

namespace job1
{
    internal class Program
    {   
        delegate double CalculateFigure(double r);
        
            public static double Get_Length(double r)
            {
                double result = 2 * Math.PI * r;
                Console.WriteLine("Circle length: {0:f2}", result);
                return result;
            }
            public static double Get_Area(double r)
            {
                double result = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Circle square: {0:f2}", result);
                return result;
            }
            public static double Get_Volume(double r)
            {
                double result = (4 / 3) * Math.PI * Math.Pow(r, 3);
                Console.WriteLine("Circle volume: {0:f2}", result);
                return result;
            }
            static void Main(string[] args)
            {
                Console.Write("Radius = ");
                CalculateFigure CF = new CalculateFigure(Get_Length);
                double r = Convert.ToDouble(Console.ReadLine());
                CF += Get_Area;
                CF += Get_Volume;
                CF(r);
                Console.ReadLine();
            }
        }
    }


  
