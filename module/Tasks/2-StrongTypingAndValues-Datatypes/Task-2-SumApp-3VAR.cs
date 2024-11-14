using System;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int a = 5;
            decimal b = 3m;

            // Calculate the sum as a decimal
            decimal sum = a + b;

            // Print out the result
            Console.WriteLine("The value of a is: " + a);
            Console.WriteLine("The value of b is: " + b);
            Console.WriteLine("The sum of a and b is: " + sum);
        }
    }
}
