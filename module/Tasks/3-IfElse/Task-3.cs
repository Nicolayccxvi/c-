using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Set colors for terminal
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        // Welcome message
        Console.WriteLine("Welcome to pick a hobby, Goblin!");
        Thread.Sleep(2000);

        // Ask for the user's name
        Console.Write("\nEnter your name, Goblin: ");
        string userName = Console.ReadLine();
        Thread.Sleep(1500);

        // Greet the user with their name
        Console.WriteLine($"\nHello {userName}, let the fun begin!");
        Thread.Sleep(2000);

        // List hobbies
        string[] hobbies = {
            "Coin collecting",
            "Gardening",
            "Painting",
            "Reading esoteric texts",
            "Gaming",
            "Finance",
            "Chess",
            "Cooking",
            "Exploring mythology",
            "Woodworking"
        };

        Console.WriteLine("\nHere are some hobbies you can choose from:");
        Thread.Sleep(1500);

        for (int i = 0; i < hobbies.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {hobbies[i]}");
            Thread.Sleep(1000); // Short delay for each hobby
        }

        // Ask if the user wants to roll the dice
        Console.Write("\nDo you want to roll the magical goblin dice? (yes/no): ");
        string choice = Console.ReadLine()?.Trim().ToLower();
        Thread.Sleep(1500);

        if (choice == "no")
        {
            Console.WriteLine("\nFool! You have chosen to miss out on the goblin's wisdom.");
            Thread.Sleep(2000);
            return; // Exit the program
        }
        else if (choice == "yes")
        {
            // Roll the dice animation
            Console.WriteLine("\nRolling the magical goblin dice...");
            Thread.Sleep(1000);

            Random random = new Random();
            int diceRoll = 0;

            // Simulate the dice roll animation
            for (int i = 0; i < 10; i++) // Roll 10 times before landing
            {
                diceRoll = random.Next(1, hobbies.Length + 1);
                Console.Write($"\rThe dice spins... {diceRoll}   "); // Overwrite line for animation
                Thread.Sleep(200); // Quick roll animation
            }

            Console.WriteLine($"\n\nThe dice lands on... {diceRoll}!");
            Thread.Sleep(2000);

            // Reveal the hobby
            Console.WriteLine($"\nYour magical hobby is: {hobbies[diceRoll - 1]}!");
            Thread.Sleep(2000);

            // Reward the user
            Console.WriteLine("\nWhat a fantastic choice! The goblin is pleased.");
            Thread.Sleep(2500);
        }
        else
        {
            Console.WriteLine("\nInvalid choice, Goblin.");
            Thread.Sleep(2000);
        }

        Console.WriteLine("\nThank you for playing, Goblin!");
        Thread.Sleep(2500);
    }
}


