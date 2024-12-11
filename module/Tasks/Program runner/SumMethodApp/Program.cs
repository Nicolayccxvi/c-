using System;
using System.Collections.Generic;

class CCXVI
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3 };
        numbers.Add(216);
        Console.WriteLine("numbers in the list:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

