try
{
    Console.Write("Введите стоимость монитора: ");
    double monPrice = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите стоимость системного блока: ");
    double boxPrice = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите стоимость клавиатуры: ");
    double keyboardPrice = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите стоимость мыши: ");
    double mousePrice = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите количество компьютеров: ");
    double compQuantity = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Стоимость 3 компьютеров = {(monPrice + boxPrice + keyboardPrice + mousePrice) * 3}");
    Console.WriteLine($"Стоимость {compQuantity} компьютеров = {(monPrice + boxPrice + keyboardPrice + mousePrice) * compQuantity}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}