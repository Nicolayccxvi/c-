using System;

namespace SumMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the AddNumbers method
            int num1 = 5;
            int num2 = 3;
            int result = AddNumbers(num1, num2);

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + result);
        }

        // Method that takes two integers and returns their sum
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
