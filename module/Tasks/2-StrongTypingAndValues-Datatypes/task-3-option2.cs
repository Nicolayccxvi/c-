using System;

class Program
{
    // Declare x and y as global variables
    int x = 7;
    int y = 3;

    public int AddTwoNumbers()
    {
        return x + y; 
    }

    public void PrintMessage()
    {
        Console.WriteLine("This method returns nothing.");
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        
        int result = program.AddTwoNumbers();
        Console.WriteLine("The sum of x and y is: " + result);

        
        program.PrintMessage();
    }
}
