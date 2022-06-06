class Program
{
    static void Main(string[] args)
    {
        Phone phone = new Phone();
        phone.Launch("Android 5.1");
        Console.WriteLine(phone.OS.Name);

        phone.OS = OS.getInstance("Android 8");
        Console.WriteLine(phone.OS.Name);

        Console.ReadLine();
    }
}
class Phone
{
    public OS OS { get; set; }
    public void Launch(string osName)
    {
        OS = OS.getInstance(osName);
    }
}
class OS
{
    private static OS instance;

    public string Name { get; private set; }

    protected OS(string name)
    {
        this.Name = name;
    }

    public static OS getInstance(string name)
    {
        if (instance == null)
            instance = new OS(name);
        return instance;
    }
}