using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the systemchecker");

        // Display machine name
        Console.WriteLine($"Machine Name: {Environment.MachineName}");

        // Display operating system version
        Console.WriteLine($"Operating System/os: {Environment.OSVersion}");

        // Display the current user's name
        Console.WriteLine($"UserName: {Environment.UserName}");
    }
}
