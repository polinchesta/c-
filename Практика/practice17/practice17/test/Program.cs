using ClassLibrary1;
using FigureLib;
using Otdyx;
try
{
    Figure figuretrianle = new Triangle(7, 5, 3);
    Console.WriteLine("Фигура треугольник создана с заданными координатами");

    RectangleFigure figurerectangle = new Rectangle(10, 10);
    Console.WriteLine("Фигура прямоугольник создана с заданными координатами");

    OtdyxVip otdyxVip = new OtdyxVip("Грецию", 700, "Бизнес-класс");
    Console.WriteLine(otdyxVip.ShowInfo());

    Console.WriteLine("Введите количество денег для оплаты:");
    decimal price = decimal.Parse(Console.ReadLine());
    Console.WriteLine(otdyxVip.BuyOtdyx(price));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();