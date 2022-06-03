namespace RefactoringGuru.DesignPatterns.Prototype.Conceptual
{
    public class Harvest
    {
        public int? Age = null;
        public string? Title = null;
        public IdInfo? IdInfo = null;

        public Harvest ShallowCopy()
        {
            return (Harvest)this.MemberwiseClone();
        }

        public Harvest DeepCopy()
        {
            Harvest clone = (Harvest)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Title = Title;
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Harvest p1 = new Harvest();
            p1.Age = 1;
            p1.Title = "Wheat";
            p1.IdInfo = new IdInfo(1);

            Harvest p2 = p1.ShallowCopy();

            Harvest p3 = p1.DeepCopy();

            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);


            p1.Age = 2;
            p1.Title = "Corn";
            p1.IdInfo.IdNumber = 2;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            var animals = new Dictionary<int, Harvest>();
            animals[p1.IdInfo.IdNumber] = p1;
            animals[p2.IdInfo.IdNumber] = p2;
            animals[p3.IdInfo.IdNumber] = p3;
        }

        public static void DisplayValues(Harvest p)
        {
            Console.WriteLine("      Title: {0:s}, Age: {1:d}",
                p.Title, p.Age);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}