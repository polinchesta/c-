    Console.Write("Введите номер вагона: ");

    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= 10 && number <= 17)
        {
            Console.WriteLine("Вагон купейный");
        }
        else
            Console.WriteLine("Вагон плацкартный");
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }