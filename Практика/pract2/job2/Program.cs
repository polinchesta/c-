using System;

namespace job2
{
    internal class Program
    {
        public class Mlekop : Animal
        {
            string title;
            public Mlekop() : base()
            {
                this.title = string.Empty;
                Input();
            }
            void Input()
            {
                Console.WriteLine("Введите название млекопитающего : ");
                title = Console.ReadLine();
            }
            public override string Vivod()
            {
                return base.Vivod() + "\n" +
                    " Имя - "+ title +" ";
            }
        }
        static void Main(string[] args)
        {
            Animal ziv = new Mlekop();
            ziv.Vvod();
            Console.WriteLine(ziv.Vivod());
        }
    }
    public class Parnok : Animal
    {
        string title;
        public Parnok() : base()
        {
            this.title = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название животного ");
            title = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название парнокопытного - " + title + " ";
        }

    }
    public class Bird : Animal
    {
        string title;

        public Bird () : base()
        {
            this.title = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название птицы: ");
            title = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название птицы- " + title+ " ";
        }
    }
    public class Animal
    {
        int years;
        string vid_animal;
        public Animal()
        {
            this.vid_animal = String.Empty;
            this.years = 0;
            //Vvod();
        }
        public void Vvod()
        {
            Console.WriteLine("Введите разновидность животного: ");
            vid_animal = Console.ReadLine();
            Console.WriteLine("Введите количество лет: ");
            years = int.Parse(Console.ReadLine());
            
        }
        public virtual string Vivod()
        {
            return "Разновидность животного - " + vid_animal + "\n" +
                "Количество лет - " + years + "\n";
        }
    }
}
