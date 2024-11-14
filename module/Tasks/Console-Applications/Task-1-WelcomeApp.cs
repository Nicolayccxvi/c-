using System;

namespace WelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a message to the console
            Console.WriteLine("Hello, what is your name?");
            
            // Read user input
            string name = Console.ReadLine();
            
            // Print out the welcome message with the user's name
            Console.WriteLine("Welcome " + name + "!");
        }
    }
}
