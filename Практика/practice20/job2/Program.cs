try
{
    Task[] tasks = new Task[2];
    var x = 2;

    for (int i = 0; i < tasks.Length; i++)
    {
        if (i == 0)
        {
            tasks[i] = Task.Factory.StartNew(() =>
            {
                double result = ((Math.Sin( 2 * x)) + (Math.Sin(5 * x)) - (Math.Sin(3 * x))) / ((Math.Cos(x) + 1 - (2 * (Math.Pow(Math.Sin(x), 2))) * 2 * x));
                Thread.Sleep(2000);
                Console.WriteLine(result);
            });
            tasks[i].Wait();
        }
        else
        {
            tasks[i] = Task.Factory.StartNew(() =>
            {
                double result = (2 * Math.Sin( x ));
                Thread.Sleep(2500);
                Console.WriteLine(result);
            });
            tasks[i].Wait();
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}