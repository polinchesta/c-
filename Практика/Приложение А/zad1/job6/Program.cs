Console.WriteLine("Input a tree-digit number: ");
int Number = int.Parse(Console.ReadLine());
int SecondNumber = Number / 100 + Number % 10;
Console.WriteLine("Numbers = " + SecondNumber);