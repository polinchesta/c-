namespace Задача_1__Задание_2_
{
    class Program
    {
        static void Main()
        {
            FileStream file1 = new FileStream(@"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job5\file1.dat", FileMode.Create, FileAccess.ReadWrite); //создаем файловый поток
            StreamWriter writer1 = new StreamWriter(file1);//создаем «потоковый писатель» и связываем его с файловым потоком
            FileStream file2 = new FileStream(@"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job5\file2.dat", FileMode.Create, FileAccess.ReadWrite); //создаем файловый поток
            StreamWriter writer2 = new StreamWriter(file2);//создаем «потоковый писатель» и связываем его с файловым потоком

            Console.WriteLine("Введите количество элементов в первом файле");
            int first = int.Parse(Console.ReadLine());
            int[] arr;
            Console.WriteLine("Введите начало диапазона");
            int nach = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int konec = int.Parse(Console.ReadLine());
            Random rnd = new Random();//создаём метод
            arr = new int[first];    //выделяем память под массив требуемой длины
            for (int i = 0; i < first; i++)
            {
                arr[i] = rnd.Next(nach, konec);//заполнение массива случайными числами
            }
            Array.Sort(arr);
            Console.WriteLine("Первый массив");
            for (int i = 0; i < first; i++) //выводим массив на экран
            {
                Console.Write("{0} ", arr[i]);
                writer1.Write($"{arr[i]} ");
            }
            writer1.Close();

            arr = new int[0];

            Console.WriteLine("\nВведите количество элементов во втором файле");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало диапазона");
            int nachh = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int konecc = int.Parse(Console.ReadLine());
            arr = new int[second];    //выделяем память под массив требуемой длины
            for (int i = 0; i < second; i++)
            {
                arr[i] = rnd.Next(nachh, konecc);//заполнение массива случайными числами
            }
            Array.Sort(arr);
            Console.WriteLine("Второй массив");
            for (int i = 0; i < second; i++) //выводим массив на экран
            {
                Console.Write("{0} ", arr[i]);
                writer2.Write($"{arr[i]} ");
            }
            writer2.Close();


            FileStream file4 = new FileStream(@"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job5\file1.dat", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(file4);

            string[] s1;
            s1 = reader1.ReadLine().Split();

            int min1 = int.Parse(s1[0]);
            int min2 = int.Parse(s1[0]);
            for (int i = 1; i < first; i++)
            {
                if (min1 > int.Parse(s1[i]))
                {
                    min1 = int.Parse(s1[i]);
                }
            }
            for (int i = 1; i < first; i++)
            {
                if (min2 > int.Parse(s1[i]) && int.Parse(s1[i]) != min1 || min2 == min1)
                {
                    min2 = int.Parse(s1[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nБлижайшее к минимальному:{0}", min2);

            arr = new int[first];


            Array.Resize(ref s1, s1.Length - 1);
            arr = Array.ConvertAll(s1, int.Parse);
            int nul1 = 0;
            int polozh1 = 0;
            int otric1 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    nul1++;
                if (arr[i] > 0)
                    polozh1++;
                else otric1++;
            }

            Console.WriteLine("\nПоложительныx в первом файле: {0}", polozh1);
            Console.WriteLine("\nОтрицательныx в первом файле: {0}", otric1);
            Console.WriteLine("\nНулей в первом файле: {0}", nul1);
            Console.WriteLine();

            int t = 0;
            int kol = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1] || arr[i] == arr[i + 1])
                {
                    t = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = t;
                    kol++;
                }
            }
            Boolean f = true;
            for (int i = 0; i < arr.Length - 1; i++)
                if ((arr[i] > 0 && arr[i + 1] < 0) || (arr[i] < 0 && arr[i + 1] > 0))
                    continue;
                else
                {
                    f = false;
                    break;
                }
            Console.WriteLine(f ? "Знакочередующаяся последовательность" : "Не знакочередующаяся последовательность");

            reader1.Close();

            Console.WriteLine();
            if (kol == arr.Length)
                Console.WriteLine("Элементы в первом файле упорядочены");
            else Console.WriteLine("Элементы во втором файле не упорядочены");


            FileStream file5 = new FileStream(@"C:\Users\Полина\Desktop\Кпияп\Практика\practice16\job5\file2.dat", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(file5);
            arr = new int[second];
            string[] s2 = reader2.ReadLine().Split();
            Array.Resize(ref s2, s2.Length - 1);
            arr = Array.ConvertAll(s2, int.Parse);
            int nul2 = 0;
            int polozh2 = 0;
            int otric2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    nul2++;
                if (arr[i] > 0)
                    polozh2++;
                else otric2++;
            }
            Console.WriteLine("\nПоложительныx во втором файле: {0}", polozh2);
            Console.WriteLine("\nОтрицательныx во втором файле: {0}", otric2);
            Console.WriteLine("\nНулей во втором файле: {0}", nul2);
            reader2.Close();

            Console.WriteLine();

            if (nul1 > nul2)
                Console.WriteLine("Нулей больше в первом файле");
            if (nul1 < nul2)
                Console.WriteLine("Нулей больше во втором файле");
            if (nul1 == nul2)
                Console.WriteLine("Нулей одинаково");

            if (polozh1 > polozh2)
                Console.WriteLine("Положительных больше в первом файле");
            if (polozh1 < polozh2)
                Console.WriteLine("Положительных больше во втором файле");
            if (polozh1 == polozh2)
                Console.WriteLine("Положительных одинаково");

            if (otric1 > otric2)
                Console.WriteLine("Отрицательных больше в первом файле");
            if (otric1 < otric2)
                Console.WriteLine("Отрицательных больше во втором файле");
            if (otric1 == otric2)
                Console.WriteLine("Отрицательных одинаково");


            Console.ReadKey();
        }
    }
}