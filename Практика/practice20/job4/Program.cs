try
{
    const int A = -8;
    const int B = 5;

    Console.Write("Введите х: ");
    var x = int.Parse(Console.ReadLine());

    Parallel.For(A, B, Task);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Task(int x)
{
    Console.WriteLine($"Result = {Math.Pow(Math.Cos(x), 2)}");
}