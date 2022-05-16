namespace ConsoleApp2
{
    internal class Program
    {
        static double f(double x)
        {
            double y = 0;
            if (x < 0) y = (Math.Pow(0.2 * x, 2) - x - 0.1);
            else if (x >= 1) y = 0;
            else if ((x > 0) & (x != 0.1)) y = Math.Pow(x, 2) / (x - 0.1);
            return y;
        }

        static void f(double x, out double yk)
        {
            yk = 0;
            if (x < 0) yk = (Math.Pow(0.2 * x, 2) - x - 0.1);
            else if (x >= 1) yk = 0;
            else if ((x > 0) & (x != 0.1)) yk = Math.Pow(x, 2) / (x - 0.1);
            Console.WriteLine(yk);
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
            {
                f(i, out double yk);
            }
            Console.ReadLine();
        }

    }
}
