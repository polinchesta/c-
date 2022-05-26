using System;

namespace job2
{
    public delegate int Del(int first_number, int second_number);
    class Program
    {
        static Func<int, int, double> Sum = (int fn, int sn) => fn + sn;
        static Func<int, int, double> Sub = (int fn, int sn) => fn - sn;
        static Func<int, int, double> Mul = (int fn, int sn) => fn * sn;
        static Func<int, int, double> Div = (int fn, int sn) => { if (fn == 0) return -1; else return fn / sn; };
        static void Main(string[] args)
        {
            Get_Result();
        }
        static void Get_Result()
        {
            Console.Write("Input first number = ");
            int fn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number =");
            int sn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Adding result: {fn + sn}");
            Console.WriteLine($"Substract result:{fn - sn} ");
            Console.WriteLine($"Mul result: {fn * sn}");
            string message = "Not a number!";
            Console.WriteLine($"Div result: {fn/sn}");
            if (fn == 0 || sn == 0)
            {
                Console.WriteLine($"Div by zero result: {message}");
            }
        }
    }
}

    

  
