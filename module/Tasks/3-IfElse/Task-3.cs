using System;
//Oppgave 3:
//Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
//skal metoden returnere true. Ellers returnerer metoden false
class Program
{
    static bool checkIf30(num1, num2)
    {
        if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Console.Readline("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Readline("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (checkIf30(num1, num2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    
}
