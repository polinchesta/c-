double price;

try
{
    Console.Write("Введите расстояние: ");
    var s = double.Parse(Console.ReadLine());

    Console.Write("Введите расход: ");
    var rashod = double.Parse(Console.ReadLine());

    Console.Write("Введите цену за бензин: ");
    var priceGasoline = double.Parse(Console.ReadLine());

    price = (s / 100) * rashod * priceGasoline * 2;
    Console.WriteLine($"\nresult = {price}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



