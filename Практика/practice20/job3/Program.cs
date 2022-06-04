try
{
    Console.Write("Введите трехзначное число: ");
    var str = Console.ReadLine();
    int number = int.Parse(str);
    var lastNum = 0;
    var firstNum = 0;
    var summa = 0;

    if (str.Length == 3)
    {
        Task task1 = new Task(() =>
        {
            lastNum = number % 10;
            firstNum = number / 100;
            summa = lastNum + firstNum;
        });
        Task task2 = task1.ContinueWith(t => Console.WriteLine($"Summa = {summa}\n"));
        task1.Start();
        task2.Wait();
    }
    else
    {
        Console.WriteLine("Введено не трехзначное число!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}