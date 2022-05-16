Console.Write("Введите трёхзначное число: ");

try
{
    string number = Console.ReadLine();
    int[] digits = number.Select(c => (int)char.GetNumericValue(c)).ToArray();

    if (digits[1] / digits[0] == digits[2] / digits[1])
        Console.WriteLine("Цифры данного трехзначного числа образуют геометрическую прогрессию");
    else
        Console.WriteLine("Цифры данного трехзначного числа не образуют геометрическую прогрессию");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}