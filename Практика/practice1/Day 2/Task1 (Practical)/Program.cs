try
{
    Console.Write("Введите x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    double y = 0;
    if (x > 2)
    {
        y = Math.Pow(x, 3) * Math.Sqrt(x - 2);
    }
    
    if (x == 2)
    {
        y = x * Math.Sin(2 * x);
    }

    if (x < 2)
    {
        y = Math.Pow(Math.E, -2 * x) * Math.Cos(2 * x);
    }

    Console.WriteLine($"y = {Math.Round(y, 2)}");
        
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}