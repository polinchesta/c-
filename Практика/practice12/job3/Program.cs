using System;

namespace job3
{
    internal class Program
        {
            delegate string Operations(string str);
            static void Main(string[] args)
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                Operations op = upper;
                Console.WriteLine("Высокий регистр: " + op(str));
                op += lower;
                Console.WriteLine("Низкий регистр: " + op(str));
                op += letter3;
                Console.WriteLine("Начальная буква стала последней: " + op(str));
                Console.Read();
            }
            private static string lower(string str)
            {
                return str.ToLower();
            }
            private static string upper(string str)
            {
                char ch = 'o';
                int indexOfChar = str.IndexOf(ch);
                return str.ToUpper();
            }
            private static string letter3(string str)
            {
                return str.Replace(str[0], str[str.Length - 1]);
            }
        }

    }


