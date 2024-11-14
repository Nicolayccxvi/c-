using System;

namespace CCXVI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 13.0809m;
            decimal y = 94.9934m;

            decimal sum = addNumbers(x, y);

            // Use string interpolation and format the output to show four decimal places
            Console.WriteLine($"The sum of {x:F4} and {y:F4} is: {sum:F4}");
        }

        static decimal addNumbers(decimal x, decimal y)
        {
            return x + y;
        }
    }
}

