internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Первое имя: ");
        string firstname = Console.ReadLine();
        Console.Write("Второе имя: ");
        string secondname = Console.ReadLine();
        MyInfo Chell = new MyInfo(firstname);
        Console.Write("Неизменное имя: ");
        Console.WriteLine(Chell.name);
        Chell.Information += result;
        Chell.Put(secondname);
        Console.WriteLine($"Измененное имя: {Chell.name}");
        Chell.Information -= result;
        Console.Read();
    }
    private static void result(string message)
    {
        Console.WriteLine(message);
    }
}
internal class MyInfo
{
    public delegate void myInfo(string message);
    public event myInfo Information;
    public MyInfo(string name)
    {
        this.name = name;
    }
    public string name { get; private set; }
    public void Put(string ima)
    {
        name = ima;
        Information?.Invoke($"Изменить имя на: {ima}");
    }
    private void Invoke(string v)
    {
        throw new NotImplementedException();
    }
}
