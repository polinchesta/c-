try
{
    var s = new List<Clothes>() { new Coat("Coat", 1), new Suit("Crow", 1), new Coat("Coat", 2), new Suit("Crow", 2), new Coat("Coat", 3), new Suit("Crow", 3) };

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
abstract class Clothes
{
    public abstract string Cloth { get; set; }
    public abstract void Calculate();

}
class Coat : Clothes
{
    public override string Cloth { get; set; }
    private double boxsizeV;
    public Coat(string cloth, double boxsizeV)
    {
        this.Cloth = cloth;
        this.boxsizeV = boxsizeV;
    }
    public override void Calculate()
    {
        Console.WriteLine("Calculating the {0} / Object type is: {1}", this.Cloth, this.GetType());
        Console.WriteLine($"Wingspan = {boxsizeV}");
        Console.WriteLine($"Result = {(double)(boxsizeV * 1 / 2000)}");
    }
}
class Suit : Clothes
{
    public override string Cloth { get; set; }
    private double fieldgrowthH;
    public Suit(string cloth, double fieldgrowthH)
    {
        this.Cloth = cloth;
        this.fieldgrowthH = fieldgrowthH;
    }
    public override void Calculate() // override - используется, чтобы переписать метод (метод Calculate() родительского класса)
    {
        Console.WriteLine("Calculating the {0} / Object type is: {1}", this.Cloth, this.GetType());
        Console.WriteLine($"height = {fieldgrowthH}");
        Console.WriteLine($"Result = {(double)(0.8 * fieldgrowthH)}");
    }
}

