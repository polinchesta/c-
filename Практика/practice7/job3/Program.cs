using System;
using System.Text.RegularExpressions;

namespace job3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для определения почты");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"([a-z]+[0-9]+@[a-z]+[.]+[a-z])");
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Groups[1]);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.ReadLine();
        }
    }
}
