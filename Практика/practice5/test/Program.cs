try
{
    Console.Write($"Введите N = ");
    var n = int.Parse(Console.ReadLine());

    Console.Write($"Введите a = ");
    var a = int.Parse(Console.ReadLine());

    Console.Write($"Введите b = ");
    var b = int.Parse(Console.ReadLine());

    int[,] matrix = new int[n, n];
    int summI = 0;
    double summPow = 0;
    Random r = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = r.Next(a, b);
        }
    }

    Console.WriteLine("\nМатрица:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] > 0)
            {
                summPow += Math.Pow(matrix[i, j], 2);
            }
        }
        Console.WriteLine($"Сумма квадратов положительных элементов строки {i} = {summPow}");
        summPow = 0;
    }

    Console.WriteLine("\nСумма каждой строки:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            summI += matrix[i, j];
        }
        Console.WriteLine($"Summ {i} строки = {summI}");
        summI = 0;
    }

}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
