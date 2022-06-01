namespace job1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string file = @"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job1\g.txt";
            int line = 4;
            var ran = new Random(0);
            using (StreamWriter sw = new StreamWriter(file))
            {
                for (int i = 0; i < line; i++)
                    sw.WriteLine(ran.Next());
            }
            //создали файл с числами

            int count = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    int temp = int.Parse(sr.ReadLine());
                    if (temp % 2 == 0)
                        count++;
                }
            }
            Console.WriteLine("Количество четных: " + count);

            Console.ReadKey();
        }

    }
}