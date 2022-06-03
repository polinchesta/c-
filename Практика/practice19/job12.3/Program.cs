using System;

namespace job12._3
{
        internal class Program
        {
            /// <summary>
            /// создание делегата
            /// </summary>
            /// <param name="str"></param>
            /// <returns>Вывод результатов</returns>
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
            /// <summary>
            /// Возвращает низкий регитср
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            private static string lower(string str)
            {
                return str.ToLower();
            }
            /// <summary>
            /// Возвращает высокий регистр
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            private static string upper(string str)
            {
                char ch = 'o';
                int indexOfChar = str.IndexOf(ch);
                return str.ToUpper();
            }
            /// <summary>
            /// замена буквы
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            private static string letter3(string str)
            {
                return str.Replace(str[0], str[str.Length - 1]);
            }
        }
    }

