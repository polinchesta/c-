    try
    {
        const double A = Math.PI / 3;
        const double B = 3 * Math.PI / 2;
        const double M = 15;

        double h = (B - A) / M;

        double result = 0;
        double x = 0;
        for (double i = 0.1; i < 2.1; i += 0.1)
        {
            x = i + h;
            result = Math.Cos(Math.Pow(x, 2));
            Console.WriteLine("x = " + result);
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }