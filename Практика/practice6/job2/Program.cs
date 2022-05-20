Console.Write(" ");
string str = Console.ReadLine();
var result = string.Concat(str.Split(new Char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(word => word.Last()));
Console.WriteLine(result);
Console.ReadKey(true);