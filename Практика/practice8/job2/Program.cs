using System;

namespace job2
{
    
    
        enum positions
    {
            manager = 170,
            seller = 200,
            teacher = 300,
            actor = 400,
            Baker = 50,
        Manager = 401,
        Actor = 402,
    }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" All positions");
                Console.WriteLine();
                Console.WriteLine(" 1. Manager");
                Console.WriteLine(" 2. Seller");
                Console.WriteLine(" 3. Teacher");
                Console.WriteLine(" 4. Actor");
                Console.WriteLine(" 5. Baker");
                Console.WriteLine();
                Console.Write("Choose position: ");
                int a = Convert.ToInt16(Console.ReadLine());
                positions worker = new positions();
                switch (a)
                {
                    case 1:
                        {
                            Console.Write("Number of hours worked to receive bonus: ");
                            Console.WriteLine((int)positions.Manager);  worker =positions.Manager;
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Number of hours worked to receive bonus: ");
                            Console.WriteLine((int)positions.seller); worker = positions.seller;
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Number of hours worked to receive bonus: ");
                            Console.WriteLine((int)positions.teacher); worker = positions.teacher;
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Number of hours worked to receive bonus: ");
                            Console.WriteLine((int)positions.actor); worker = positions.Actor;
                        }
                        break;
                    case 5:
                        {
                            Console.Write("Number of hours worked to receive bonus: ");
                            Console.WriteLine((int)positions.Baker); worker = positions.Baker;
                        }
                        break;
                    default: Console.WriteLine("The entered number is not recognized.."); break;
                }

                Console.WriteLine();
                Console.WriteLine("Enter the number of hours worked per month: ");
                int h = Convert.ToInt16(Console.ReadLine());
                Accountant d = new Accountant();
                Console.WriteLine("the presence of a premium ");
                Console.WriteLine(d.AskForBonus(worker, h));
                Console.ReadLine();
            }
        }
    }

