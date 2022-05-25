try
{
    var s = new List<Clothes>(){new Clothes("Unidentified Clothes"),
            new Coat("Coat",1), new Suit("Suit",1),
            new Coat("Coat",2), new Suit("Suit",2),
            new Coat("Coat",3), new Suit("Suit",3)};

    foreach (Clothes p in s)
    {
        p.Calculate();
        Console.WriteLine();
    }
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Clothes
{
    private string _Cloth { get; set; }
    public Clothes(string cloth)
    {
        this._Cloth = cloth;
    }
    public virtual void Calculate() //virtual - можем переписывать этот метод (метод Calculate())
    {
        Console.WriteLine("Calculating the {0} / Object type is: {1}", this._Cloth, this.GetType());

    }
}
class Coat : Clothes
{
    private double boxsizeV;
    public Coat(string cloth, double boxsizeV) : base(cloth)
    {
        this.boxsizeV = boxsizeV;
    }
    public override void Calculate()
    {
        base.Calculate(); //base - вызывает этот метод в родительском классе (метод Calculate())
        Console.WriteLine($"Wingspan = {boxsizeV}");
        Console.WriteLine($"Result = {(double)(boxsizeV / 6.5 + 0.5)}");
    }
}
class Suit : Clothes
{
    private double fieldgrowthH;
    public Suit(string cloth, double fieldgrowthH) : base(cloth)
    {
        this.fieldgrowthH = fieldgrowthH;
    }
    public override void Calculate() // override - используется, чтобы переписать метод (метод Calculate() родительского класса)
    {
        base.Calculate();
        Console.WriteLine($"height = {fieldgrowthH}");
        Console.WriteLine($"Result = {(double)(2 * fieldgrowthH + 0.3)}");
    }
}