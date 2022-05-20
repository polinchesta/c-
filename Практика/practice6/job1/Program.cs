namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "Привет! Чем ты теперь занимаешься? Рад был тебя видеть.";
            bool index = true;//печатаем слово или нет
            char c = Convert.ToChar(Console.Read());
            string outt = "";//выходная строка
            string slowo = ""; //строка для временного хранения слова
            for (int i = 0; i < p.Length; i++)
            {
                if (Char.IsLetter(p[i]))//проверяем является ли символ буквой
                {
                    slowo += p[i];
                    //добавляем букву к слову
                    if (Char.ToLower(p[i]) == Char.ToLower(c)) index = false;
                    //проверяем входить ли в слово нужный символ
                }
                else
                {
                    if (index) outt += slowo;
                    //если в слово не входит символ печатаем его
                    index = true;
                    slowo = "";
                    // следующее слово изначально пустое
                    outt += p[i];
                    // добавляем текущий символ к выходному файлу
                }
            }
            Console.WriteLine(outt);
        }
    }
}
