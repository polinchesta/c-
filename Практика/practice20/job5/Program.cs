try
{
    var multV = 1;
    var summV = 0;
    ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 3, 7, 93, 90 }, Mult);

    void Mult(int n, ParallelLoopState pls)
    {
        Console.WriteLine($"Result mult = {multV *= n}");
        Console.WriteLine($"Result summ = {summV += n}");

        if (multV > 35)
        {
            Console.WriteLine("Цикл прерван (mult > 35)");
            pls.Break();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}