using System;
namespace Array_from_set_user_parameter5
{
    /* Продемонстрировать одномерный массив из дробных чисел.
    Количество элементов массива задаётся с клавиатуры */
    class Program
    {
        static void Main(string[] args)
        {
            // Задать с клавиатуры число элементов массива
            int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt32(Console.ReadLine());
            // Объявим одномерный массив Data с n-элементами 
            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элемент массива");
                /* Вводим элементы массива с клавиатуры 
                * и заполняем ими массив */
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            // Вывод содержимого массива
            for (i = 0; i < n; i = i + 1)
                Console.Write(Data[i] + " ");


            int v = 0;
            int sum = 0;
            Console.WriteLine("\nКратные пяти:");
            for (i = 0; i < n; i++)
                if (Convert.ToInt32(Data[i]) % 5 == 0)
                { 
                    Console.WriteLine("Data[" + i + "]=" + Data[i]);
                    sum += (int)Data[i];
                    v += 1; 
                }
            
            Console.WriteLine("Сред ариф:" + sum / v);
            Console.ReadKey();
        }
    }
}