namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 20;
            int M = 36;
            int[,] Matrix = new int[N, M];
            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*******************");
            Console.WriteLine("Матрица из вагонов:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int rand = random.Next(0, 2);
                    Matrix[i, j] = rand;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Введите номер вагона: ");
            int vagon = int.Parse(Console.ReadLine());

            int x = 0;

            for (int j = 0; j < Matrix.GetLength(1); j++) if (Matrix[vagon - 1, j] == 0) x++;

            Console.WriteLine($" Вагон - {vagon}."
                + $" - Свободных мест в вагоне - {x}.");
            Console.ReadKey();
        }
    }
}