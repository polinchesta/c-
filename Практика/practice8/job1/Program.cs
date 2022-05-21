namespace ConsoleApp1
{
    struct ZNAK
    {
        public string firstname;
        public string secondname;
        public string zodiac;
        public int birthD; // ДЕНЬ рождения
        public int birthM; // МЕСЯЦ рождения
        public int birthY; // ГОД рождения


        public ZNAK(string Firstname, string Secondname, string Zodiac, int BirthD, int BirthM, int BirthY) // Конструктор структуры
        {
            this.firstname = Firstname;
            this.secondname = Secondname;
            this.zodiac = Zodiac;
            this.birthD = BirthD;
            this.birthM = BirthM;
            this.birthY = BirthY;
        }
        public override string ToString()
        {
            return (string.Format(@" 
            Имя: {0} 
            Фама: {1} 
            Знак: {2}
            Дата рождения: {3}.{4}.{5} ", firstname, secondname, zodiac, birthD, birthM, birthY));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8; // Для общей инфы
            ZNAK[] mas = new ZNAK[a];
            for (int i = 0; i < a; i++) // Заполнение восьмерых человек
            {
                Console.Write("Введите имя: ");
                mas[i].firstname = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                mas[i].secondname = Console.ReadLine();
                Console.Write("Введите знак зодиака: ");
                mas[i].zodiac = Console.ReadLine();
                Console.Write("Введите ДЕНЬ рождения: ");
                mas[i].birthD = int.Parse(Console.ReadLine());
                Console.Write("Введите МЕСЯЦ рождения: ");
                mas[i].birthM = int.Parse(Console.ReadLine());
                Console.Write("Введите ГОД рождения: ");
                mas[i].birthY = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a - 1 - i; j++)
                {
                    if (mas[i].birthY > mas[j].birthY)
                    {
                        ZNAK temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            Console.WriteLine("Информация о людях (отсортированная по дате рождения): ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(mas[i]);
            }
            string flag;
            Console.WriteLine("Введите фамилию человека: ");
            flag = Console.ReadLine();
            for (int i = 0; i < a; i++)
            {
                if (mas[i].secondname == flag)
                {
                    Console.WriteLine(mas[i]);
                }
                else Console.WriteLine("такого челка нет");
                break;
            }

            Console.ReadKey();
        }
    }
}