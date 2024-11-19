using System;

class Program
{
    
    static bool CheckIf30(int num1, int num2)
    {
        if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
        {
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());  

        // Prompt and get user input for num2
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());  

        
        if (CheckIf30(num1, num2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

