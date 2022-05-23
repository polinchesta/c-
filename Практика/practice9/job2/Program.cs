using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Parking park = new Parking(100);
        park.AddCar("8662AB", "red", "Вася");
        park.AddCar("4578CK", "green", "Петя");
        park.AddCar("8683MX", "blue", "Коля");
        park.AddCar("5763AA", "grey", "Дима");
        park.PrintAllCar();
        Console.WriteLine("--------------------------------------");
        park.RemCar("8683MX");
        park.AddCar("1610BM", "red", "Влад");
        park.PrintAllCar();
        Console.WriteLine("--------------------------------------");
        park.Find("red");
        Console.WriteLine("--------------------------------------");
        park.Find("8662AB");
    }
}

class Parking
{
    private bool[] place; // количество мест на стоянке, фолз - свободно, тру - занято
    private List<Car> list = new List<Car>(); // список машин
    public Parking(int count)
    {
        place = new bool[count];
    }
    public void AddCar(string number, string color, string owner) // добавить машину (номер, цвет, владелец)
    {
        for (int i = 0; i < place.Length; i++)
        {
            if (place[i] == false)
            {
                place[i] = true;
                list.Add(new Car(number, color, owner, i));
                return;
            }
        }
        Console.WriteLine("Нет свободных мест");
    }
    public void RemCar(string number) // удалить машину (номер)
    {
        foreach (Car car in list)
        {
            if (car.number == number)
            {
                list.Remove(car);
                place[car.order] = false;
                return;
            }
        }
        Console.WriteLine("Нет такой машины: [{0}]", number);
    }
    public void RemCar(int n) // удалить машину (номер места на стоянке)
    {
        foreach (Car car in list)
        {
            if (car.order == n)
            {
                list.Remove(car);
                place[car.order] = false;
                return;
            }
        }
        Console.WriteLine("Нет такой машины: [{0}]", n);
    }
    public void PrintAllCar() // вывести все машины
    {
        foreach (Car car in list)
        {
            Console.WriteLine(car);
        }
    }
    public void Find(string param) // поиск (номер/цвет/владелец)
    {
        Console.WriteLine("Поиск с параметром: [{0}]", param);
        foreach (Car car in list)
        {
            if (car.color == param || car.number == param || car.owner == param)
            {
                Console.WriteLine(car);
            }
        }
    }
    public void Find(int place) // поиск (номер места на стоянке)
    {
        Console.WriteLine("Поиск с параметром: [{0}]", place);
        foreach (Car car in list)
        {
            if (car.order == place)
            {
                Console.WriteLine(car);
            }
        }
    }

    private struct Car
    {
        public string number; // номер
        public string color; // цвет
        public string owner; // владелец
        public int order; // номер места на стоянке
        public Car(string num, string col, string own, int ord)
        {
            number = num;
            color = col;
            owner = own;
            order = ord;
        }
        public override string ToString()
        {
            return string.Format("Номер:[{0}], Цвет:[{1}], Владелец:[{2}], Место:[{3}]", number, color, owner, order);
        }
    }
}