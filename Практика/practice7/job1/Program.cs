using System;
using System.Text.RegularExpressions;

namespace job1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для определения номера");
            string text = Console.ReadLine();
            const string myReg = @"([+]?\d{1}([ ,-]?\d{3}){2}([ ,-]?\d{2}){2})";
            if (Regex.IsMatch(text, myReg, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Есть номера телефона в тексте");
            }
            else
            {
                Console.WriteLine("Нет телефонов в тексте");
            }
            Console.ReadLine();
        }
    }
}
