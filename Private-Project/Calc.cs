using System;

class AdvancedCalculator
{
    static void Main(string[] args)
    {
        // welcome message
        Console.WriteLine("Welcome to the Advanced Calculator.");
        Console.WriteLine("As above, so below. As within, so without.");
        
        // Asking user for their name
        Console.Write("Please enter your name: ");
        string? userName = Console.ReadLine();
        
        if (userName?.ToUpper() == "CCXVI")
        {
            Console.WriteLine("Welcome, Master.");
        }
        else if (!string.IsNullOrEmpty(userName))
        {
            Console.WriteLine($"Welcome, {userName}.");
        }

        // Calculator menu
        Console.WriteLine("Choose a function:");
        Console.WriteLine("1. Absolute Value");
        Console.WriteLine("2. Exponent");
        Console.WriteLine("3. Square Root");
        Console.WriteLine("4. Sine");
        Console.WriteLine("5. Cosine");
        Console.WriteLine("6. Tangent");
        Console.WriteLine("7. Logarithm");
        Console.WriteLine("8. Exit");

        while (true)
        {
            Console.Write("Choose an option (1-8): ");
            string? choice = Console.ReadLine();

            if (choice == "8")
            {
                // exit message
                Console.WriteLine("Goodbye, for as the wise know, the end is but a beginning.");
                break;
            }

            decimal num1, num2;
            decimal result;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a number: ");
                    string? input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    result = Math.Abs(num1);
                    Console.WriteLine($"Absolute Value: {result:F4}");
                    break;

                case "2":
                    Console.Write("Enter the base: ");
                    input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    Console.Write("Enter the exponent: ");
                    string? input2 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input2) || !decimal.TryParse(input2, out num2))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    result = (decimal)Math.Pow((double)num1, (double)num2);
                    Console.WriteLine($"Exponent: {result:F4}");
                    break;

                case "3":
                    Console.Write("Enter a number: ");
                    input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    result = (decimal)Math.Sqrt((double)num1);
                    Console.WriteLine($"Square Root: {result:F4}");
                    break;

                case "4":
                    Console.Write("Enter an angle in degrees: ");
                    input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    
                    result = (decimal)Math.Sin((double)(num1 * (decimal)Math.PI / 180));
                    Console.WriteLine($"Sine: {result:F4}");
                    break;

                case "5":
                    Console.Write("Enter an angle in degrees: ");
                    input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    
                    result = (decimal)Math.Cos((double)(num1 * (decimal)Math.PI / 180));
                    Console.WriteLine($"Cosine: {result:F4}");
                    break;

                case "6":
                    Console.Write("Enter an angle in degrees: ");
                    input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    
                    result = (decimal)Math.Tan((double)(num1 * (decimal)Math.PI / 180));
                    Console.WriteLine($"Tangent: {result:F4}");
                    break;

                case "7":
                    Console.Write("Enter a number: ");
                    input1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(input1) || !decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                    }
                    if (num1 <= 0)
                    {
                        Console.WriteLine("Logarithm is not defined for zero or negative numbers.");
                    }
                    else
                    {
                        result = (decimal)Math.Log((double)num1);
                        Console.WriteLine($"Logarithm: {result:F4}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine();
        }

        // exit message
        Console.WriteLine("Goodbye, for as the wise know, the end is but a beginning.");
    }
}
