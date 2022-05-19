Console.WriteLine("Введите числа через пробел:");
int[] chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.WriteLine(chisla.Where((x, index) => x % 2 != 0 && index % 2 != 0).Count());
Console.ReadKey();