class Program
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
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            double yk = 0;
            for (double i = a; i <= b; i += h)
            {
                f(i, out yk);
                Console.WriteLine($"result = {yk}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}