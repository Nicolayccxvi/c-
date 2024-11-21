using System;
using System.Threading;

//Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. Gjør dette uten å bruke innebygde reverse metoder
//Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
//Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase

class Program
{
    static void Main(string[] args)
    {
        // Set terminal text color
        Console.ForegroundColor = ConsoleColor.Green;

        // Hold user input
        string input = "";

        while (true)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.Clear();
                Console.WriteLine("Write Here:");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("\nText can't be empty. Please enter valid text.");
                    Console.WriteLine("\nPress any key to try again...");
                    Console.ReadKey();
                    continue;
                }
            }

            // Display 
            Console.Clear();
            Console.WriteLine($"Current Text: {input}");
            Thread.Sleep(200);
            Console.WriteLine("\nWhat do you want to do with the text?");
            Thread.Sleep(200);
            Console.WriteLine("1 - Reverse");
            Thread.Sleep(200);
            Console.WriteLine("2 - UPPERCASE");
            Thread.Sleep(200);
            Console.WriteLine("3 - lowercase");
            Thread.Sleep(200);
            Console.WriteLine("4 - new text");
            Thread.Sleep(200);
            Console.WriteLine("5 - Exit");
            Thread.Sleep(200);
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    input = ReverseString(input); 
                    Console.WriteLine($"\nReversed Text: {input}");
                    break;
                case "2":
                    input = input.ToUpper(); 
                    Console.WriteLine($"\nText in UPPERCASE: {input}");
                    break;
                case "3":
                    input = input.ToLower(); 
                    Console.WriteLine($"\nText in lowercase: {input}");
                    break;
                case "4":
                    input = ""; 
                    break;
                case "5":
                    Console.WriteLine("Exiting program");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please choose between 1-5.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }

    static string ReverseString(string input)
    {
        char[] reversed = new char[input.Length];
        for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
        {
            reversed[i] = input[j];
        }
        return new string(reversed);
    }
}

