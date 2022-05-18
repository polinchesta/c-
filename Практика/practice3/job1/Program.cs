namespace ConsoleApp
{
    internal class Program
    {
        static double func(double x, double y, double z)
        {
            return ((x + y + z) / 2);
        }

        static void Main(string[] args)
        {
            double a, b, c, d, e, f, g, s1, s2, s3, s, p1, p2, p3;

            Console.Write("Сторона a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона c=");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона d=");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона e=");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона f=");
            f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона g=");
            g = Convert.ToInt32(Console.ReadLine());

            p1 = Program.func(a, b, f);
            p2 = Program.func(f, g, c);
            p3 = Program.func(e, g, d);

            s1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - f)); // площадь треугольника a,b,f
            s2 = Math.Sqrt(p2 * (p2 - f) * (p2 - g) * (p2 - c)); // площадь треугольника f,g,c
            s3 = Math.Sqrt(p3 * (p3 - e) * (p3 - g) * (p3 - d)); // площадь треугольника e,g,d
            s = s1 + s2 + s3;

            Console.WriteLine("Площадь пятиугольника равна = {0:F3}", s);
        }
    }
}