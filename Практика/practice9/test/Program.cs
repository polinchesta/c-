try
{
    Test task1 = new Test(10);

    Ix taskX = task1;
    Iy taskY = task1;
    Iz taskZ = task1;

    var x = (Ix)task1;
    x.IxF0(10);

    taskX.IxF0(10);
    taskX.IxF1();

    taskY.F0(10);
    taskY.F1();

    taskZ.F0(10);
    taskZ.F1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Test: Ix, Iy, Iz
{
    public double w;

    public Test(double w)
    {
        this.w = w;
    }

    public void IxF0(double w)
    {
        Console.WriteLine(Math.Cos(w));
    }

    public void IxF1()
    {
        Console.WriteLine(Math.Cos(w));
    }

    public void F0(double w)
    {
        Console.WriteLine(Math.Exp(w));
    }
    public void F1()
    {
        Console.WriteLine(Math.Exp(w));
    }
    void Iz.F0(double w)
    {
        Console.WriteLine(1 / Math.Exp(w));
    }
    void Iz.F1()
    {
        Console.WriteLine(1 / Math.Exp(w));
    }
}

interface Ix
{
    void IxF0(double w);
    void IxF1();
}
interface Iy
{
    void F0(double w);
    void F1();
}
interface Iz
{
    void F0(double w);
    void F1();
}