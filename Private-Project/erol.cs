using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // IF/ELSE
        Console.WriteLine("Enter a number to check if it is positive, negative, or zero:");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // SWITCH
        Console.WriteLine("\nEnter a grade (A, B, C, D, F):");
        char grade = Console.ReadLine()[0];
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
                Console.WriteLine("Good job!");
                break;
            case 'C':
                Console.WriteLine("Average.");
                break;
            case 'D':
                Console.WriteLine("Needs improvement.");
                break;
            case 'F':
                Console.WriteLine("Fail.");
                break;
            default:
                Console.WriteLine("Invalid grade entered.");
                break;
        }

        // ARRAYS
        Console.WriteLine("\nWorking with Arrays:");
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"First element: {numbers[0]}, Last element: {numbers[numbers.Length - 1]}");

        // LIST
        Console.WriteLine("\nWorking with Lists:");
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        names.Add("Diana");
        Console.WriteLine("Names in the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // LOOPS
        Console.WriteLine("\nUsing a loop to calculate the sum of the array:");
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Sum of array elements: {sum}");

        // REFERANSETYPE VS VERDITYPE
        Console.WriteLine("\nReference vs Value Type demonstration:");
        
        // Value type
        int a = 5;
        int b = a; // Copy value
        b = 10;
        Console.WriteLine($"Value Type: a = {a}, b = {b} (b changed, a remains the same)");

        // Reference type
        int[] array1 = { 1, 2, 3 };
        int[] array2 = array1; // Reference to the same memory location
        array2[0] = 10;
        Console.WriteLine($"Reference Type: array1[0] = {array1[0]} (Changing array2 also changes array1)");
    }
}
