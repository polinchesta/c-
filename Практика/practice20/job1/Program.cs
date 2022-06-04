try
{
    var secNum = 0;
    Console.Write("Введите четырехзначное число: ");
    var str = Console.ReadLine();

    var number = int.Parse(str);
    var f1 = 0;
    var f2 = 0;
    var f3 = 0;
    var f4 = 0;
    var temp = 0;

    Task task = new Task(() =>
    {
        for (int i = 0; i < str.Length; i++)
        {
            temp = number;
            f1 = number / 1000;
            temp = number - f1 * 1000;
            f2 = temp / 100;
            temp -= f2 * 100;
            f3 = temp / 10;
            temp -= f3 * 10;
            f4 = temp;
            secNum = f2 * 1000 + f1 * 100 + f3 * 10 + f4;
        }
        Console.WriteLine($"Result (v1) = {secNum}");
    });
    task.Start();
    task.Wait();

    var task2 = Task.Factory.StartNew(() =>
    {
        for (int i = 0; i < str.Length; i++)
        {
            temp = number;
            f1 = number / 1000;
            temp = number - f1 * 1000;
            f2 = temp / 100;
            temp -= f2 * 100;
            f3 = temp / 10;
            temp -= f3 * 10;
            f4 = temp;
            secNum = f2 * 1000 + f1 * 100 + f3 * 10 + f4;
        }
        Console.WriteLine($"Result (v2) = {secNum}");
    });
    task2.Wait();

    Task task3 = Task.Run(() =>
    {
        for (int i = 0; i < str.Length; i++)
        {
            temp = number;
            f1 = number / 1000;
            temp = number - f1 * 1000;
            f2 = temp / 100;
            temp -= f2 * 100;
            f3 = temp / 10;
            temp -= f3 * 10;
            f4 = temp;
            secNum = f2 * 1000 + f1 * 100 + f3 * 10 + f4;
        }
        Console.WriteLine($"Result (v3) = {secNum}");
    });
    task3.Wait();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
