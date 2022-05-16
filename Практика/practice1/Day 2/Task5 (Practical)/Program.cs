Console.Write("Введите N: ");

try
{
    int n = Convert.ToInt32(Console.ReadLine());

    double result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += 1 / (double)i;
    }

    Console.WriteLine($"Сумма = {Math.Round(result, 4)}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}