using System;

class Program
{
    static void Main(string[] args)
    {
        // color change on text 
        Console.ForegroundColor = ConsoleColor.Green;

        // welcome
        Console.WriteLine("Welcome to pick a hobby Goblin");


        // ask for users name
        Console.Write("Enter your name Goblin:");
        string userName = Console.ReadLine();

        // nice greeting
        Console.WriteLine($"Nice to meet you {userName}!");


        // hobbies
        string[] hobbies = new string[]
        {
              "Coin Collecting",
            "Finance and Investment",
            "Esoteric Knowledge Gathering",
            "Photography",
            "Gardening",
            "Cooking",
            "Painting",
            "Music Composition",
            "Traveling",
            "Reading Books"
        };

        Console.WriteLine("\nHere are some Hobby Ideas for you:");
        for (int i = 0; i < hobbies.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {hobbies[i]}");
        }

        // user choice the magical dice
        Console.Write("\nDo you want to roll the magical goblin dice? (yes/no): ");
        string userChoice = Console.ReadLine().ToLower();

        if (userChoice == "yes")
        {
            Random random = new Random();
            int DiceRoll = random.Next(1, 10);

            Console.WriteLine($"\nYou rolled a {DiceRoll}! Magical results await!");

            if (DiceRoll <= hobbies.Length)
            {
                Console.WriteLine($"Your magical hobby is: {hobbies[DiceRoll - 1]}");
            }
            else
            {
                Console.WriteLine("Something went wrong with the dice roll!");
            }

        }
        else if (userChoice == "no")
        {
            Console.WriteLine("\nYou chose not to roll the dice, fool!");
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
        }






    }



}

