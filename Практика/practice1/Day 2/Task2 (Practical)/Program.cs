Console.Write("Введите трёхзначное число: ");

try
{
    string number = Console.ReadLine();
    if (number[0] > number[1])
        Console.WriteLine("Первая цифра больше");
    else
        Console.WriteLine("Вторая цифра больше");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}