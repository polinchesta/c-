using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace job2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> symbols = new Queue<char>();
            Queue<char> digits = new Queue<char>();


            using (StreamReader sr = new StreamReader(@"C:\Users\Полина\Desktop\Кпияп\Практика\practice18\job2\job2.txt"))
            {

                while (!sr.EndOfStream)
                {

                    char s = (char)sr.Read();
                    if (char.IsDigit(s)) digits.Enqueue(s);
                    else symbols.Enqueue(s);

                }

            }

            Console.WriteLine(string.Join("", symbols));
            Console.WriteLine(string.Join("", digits));

            Console.ReadKey();
        }
    }
}
 

