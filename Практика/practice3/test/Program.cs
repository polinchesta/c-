try
{
    Sklad sklad = new Sklad();
    Tovar tovar = new Tovar("Молоко", "Santa", 150);
    Tovar tovar4 = new Tovar("Молоко", "Almi", 100);
    Tovar tovar1 = new Tovar("Мороженное", "Almi", 270);
    Tovar tovar2 = new Tovar("Яйца", "OldCity", 250);
    Tovar tovar3 = new Tovar("Хлеб", "Korona", 400);
    sklad.AddTovarRange(tovar, tovar1, tovar2, tovar3, tovar4);
    sklad.PrintTovar();
    sklad.GetInforation(0);
    sklad.GetInformationTovar("Молоко");
    sklad.InfoSortPrice();
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Tovar
{
    private string _name;
    private string _nameOfShop;
    private decimal _price; 

    public Tovar(string Name, string NameOfShop, decimal Price)
    {
        _name = Name;
        _nameOfShop = NameOfShop;
        _price = Price;
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string NameOfShop
    {
        get { return _nameOfShop; }
        set { _nameOfShop = value; }
    }
    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public static decimal operator +(Tovar plane1, Tovar plane2) //перегрузка операторов
    {
        return plane1.Price + plane2.Price;
    }
    public override string ToString()
    {
        return $"{_name},{_nameOfShop},{_price}";
    }
}

class Sklad
{
    List<Tovar> tovars;
    public Sklad()
    {
        tovars = new List<Tovar>();
    }

    public void AddTovar(Tovar plane)
    {
        tovars.Add(plane);
    }

    public void AddTovarRange(params Tovar[] Planes)
    {
        tovars.AddRange(Planes);
    }


    public void GetInforation(int index) // получение информации по индексу
    {
        //var isMore = tovars[0] > tovars[1]; // проверка перегрузки
        //Console.WriteLine(isMore);

        if (index > tovars.Count - 1)
        {
            throw new Exception("Товара не существует");
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Наименование товара: " + tovars[index].Name);
        Console.WriteLine("Наименование магазина: " + tovars[index].NameOfShop);
        Console.WriteLine("Цена: " + tovars[index].Price);
        Console.WriteLine("---------------------------------------------------");
    }

    public void GetInformationTovar(string userString) // получение информации о товаре по наименованию
    {
        for (int i = 0; i < tovars.Count; i++)
        {
            if (userString == tovars[i].Name)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"Наименование товара: {tovars[i].Name}");
                Console.WriteLine($"Наименование магазина: {tovars[i].NameOfShop}");
                Console.WriteLine($"Цена: {tovars[i].Price}");
                Console.WriteLine("---------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Товара не существует");
            }
        }
    }

    public void PrintTovar() // получение информации о товаре по наименованию
    {
        for (int i = 0; i < tovars.Count; i++)
        {
            Console.WriteLine($"Наименование товара: {tovars[i].Name}");
            Console.WriteLine($"Наименование магазина: {tovars[i].NameOfShop}");
            Console.WriteLine($"Цена: {tovars[i].Price}");
        }
        Console.WriteLine("---------------------------------------------------");
    }

    public void InfoSortPrice() //сортировка по цене
    {
        var temp = tovars[0];
        for (int i = 0; i < tovars.Count - 1; i++)
        {
            for (int j = i + 1; j < tovars.Count; j++)
            {
                if (tovars[i].Price > tovars[j].Price)
                {
                    temp = tovars[i];
                    tovars[i] = tovars[j];
                    tovars[j] = temp;
                }
            }
        }
        Console.WriteLine("Сортировка по цене:");
        for (int i = 0; i < tovars.Count; i++)
        {
            Console.WriteLine(tovars[i]);
        }
    }
}