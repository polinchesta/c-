try
{
    Console.Write("Введите вещественное число: ");
    float a = Convert.ToSingle(Console.ReadLine());

    Console.Write("Введите степень числа: ");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(Math.Round(Math.Pow(a, i), 4));
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}