using System;
using System.Threading;

namespace VirtualPet
{
    class VirtualPet
    {
        private string Name { get; }
        private int Age { get; }
        private int Hunger { get; set; }
        private int Happiness { get; set; }
        private int Bladder { get; set; }

        public VirtualPet(string name, int age)
        {
            Name = name;
            Age = age;
            Hunger = 50;
            Happiness = 50;
            Bladder = 0;
        }

        public void Feed()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (Hunger > 20)
            {
                Hunger -= 20;
                Bladder += 10;
                Console.WriteLine($"{Name} is full and happy now!");
            }
            else
            {
                Console.WriteLine($"{Name} is already full!");
            }
            Thread.Sleep(1000);
            Console.ResetColor();
        }

        public void Pet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Happiness += 10;
            Console.WriteLine($"{Name} smiles warmly!");
            Thread.Sleep(1000);
            Console.ResetColor();
        }

        public void CheckBladder()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (Bladder >= 50)
            {
                Console.WriteLine($"{Name} needs to go to the bathroom!");
            }
            else
            {
                Console.WriteLine($"{Name} is fine for now.");
            }
            Thread.Sleep(1000);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Virtual Pet Game!");
            Console.Write("What kind of pet would you like to take care of? ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Whaleshark"; 
            }

            Console.Write("How old is your pet? ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                age = 1; 
            }

            VirtualPet pet = new VirtualPet(name, age);
            Console.WriteLine($"\nGreat! You are now taking care of {name}, who is {age} year(s) old.\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"1. Feed {name}");
                Console.WriteLine($"2. Pet {name}");
                Console.WriteLine($"3. Check if {name} needs the bathroom");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an action: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input! Please choose a number between 1 and 4.");
                    Thread.Sleep(1000);
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        pet.Feed();
                        break;
                    case 2:
                        pet.Pet();
                        break;
                    case 3:
                        pet.CheckBladder();
                        break;
                    case 4:
                        Console.WriteLine($"Goodbye! {name} will miss you!");
                        Thread.Sleep(1000);
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please choose a number between 1 and 4.");
                        Thread.Sleep(1000);
                        break;
                }
                Console.ResetColor();
            }
        }
    }
}
