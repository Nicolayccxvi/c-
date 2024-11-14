using System;

namespace CCXVI 
{
 class Program
 {
    static void Main(string[] args)
    {
      int x = 13;
      int y = 94;

      int sum = addNumbers(x, y);

        Console.WriteLine("The sum of " + x + " and " + y + " is: " + sum);
    }

    static int addNumbers(int x, int y)
    {
        return x + y;
    }
 }
}
