Console.Write("Введите число: ");
var a = Convert.ToInt32(Console.ReadLine());
double z1 = ((Math.Sin(2 * a)) + (Math.Sin(5 * a)) - (Math.Sin(3 * a))) / ((Math.Cos(a)) - (Math.Cos(3 * a)) + (Math.Cos(5 * a))) ;
Console.Write("Answer: " + z1);
double z2 = (Math.Tan(3 * a));
Console.Write("Answer: " + z2);
Console.ReadLine();