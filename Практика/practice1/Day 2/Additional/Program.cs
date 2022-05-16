try
{
    Console.Write("Введите цифру: ");
    char k = Convert.ToChar(Console.ReadLine());

    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    string str = Convert.ToString(n);

    int count = str.Count(x => x == k);

    Console.WriteLine($"Цифра {k} входит в число {n} {count} раз");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}