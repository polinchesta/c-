public class Programm
{
    static void Main(string[] args)
    {
        var arrToFill = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

        var arr1 = new Massiv<string>(5, 5);
        var arr2 = new Massiv<string>(5, 5);

        arr1.Fill(arrToFill);
        arr2.Fill(arrToFill);

        arr1.Print();
        Console.WriteLine();
        arr2.Print();

        if (arr1 == arr2) Console.WriteLine("Arrays are equal!");
        else Console.WriteLine("Arrays are not equal!");

        Console.ReadLine();
    }


}

public class Massiv<T>
{
    private readonly T[,] _arr;
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public Massiv(int rows, int columns)
    {
        RowCount = rows;
        ColumnCount = columns;
        _arr = new T[RowCount, ColumnCount];
    }

    public void Print(int coloredRow = -1, int coloredColumn = -1)
    {
        var maxLength = MaxLength();

        for (int i = 0; i < RowCount; i++)
        {
            Console.Write("|");

            if (coloredRow == i) Console.ForegroundColor = ConsoleColor.Red;

            for (int j = 0; j < ColumnCount; j++)
            {
                if (coloredColumn == j) Console.ForegroundColor = ConsoleColor.Red;

                var anz = maxLength - _arr[i, j].ToString().Length;
                var l = Spaces(anz);

                if (coloredRow != i && coloredColumn != j) Console.ResetColor();

                Console.Write(" " + _arr[i, j] + l + " ");
            }

            Console.ResetColor();
            Console.Write("|\n");
        }
    }

    private static string Spaces(int count)
    {
        var result = "";
        for (int i = 0; i < count; i++) result += " ";
        return result;
    }

    private int MaxLength()
    {
        int max = int.MinValue;

        for (int i = 0; i < RowCount; i++)
        {
            for (int j = 0; j < ColumnCount; j++)
            {
                if (_arr[i, j].ToString().Length > max) max = _arr[i, j].ToString().Length;
            }
        }

        return max;
    }

    public void Fill(T[] toFill)
    {
        var rnd = new Random();

        for (int i = 0; i < RowCount; i++)
        {
            for (int j = 0; j < ColumnCount; j++)
            {
                T value = toFill[rnd.Next(toFill.Length)];
                _arr[i, j] = value;
            }
        }
    }

    public static bool operator ==(Massiv<T> arr1, Massiv<T> arr2)
    {
        for (int i = 0; i < arr1.RowCount; i++)
        {
            for (int j = 0; j < arr2.ColumnCount; j++)
            {
                if (!arr1._arr[i, j].Equals(arr2._arr[i, j])) return false;
            }
        }

        return true;
    }

    public static bool operator !=(Massiv<T> arr1, Massiv<T> arr2)
    {
        return !(arr1 == arr2);
    }

    public T this[int row, int column]
    {
        get { return _arr[row, column]; }
        set { _arr[row, column] = value; }
    }
}