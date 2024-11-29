using System;
using System.Threading; 

namespace CCXVI
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 90;
            int Num2 = 180;
            int Addsum = AddNumbers(Num1, Num2); 

            Console.WriteLine("hello");
            Console.WriteLine($"The sum of {Num1} + {Num2} = {Addsum}");

            while (Num1 <= Num2) 
            {
                if (Num1 < Num2)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine($"{Num1} is smaller than {Num2}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine($"{Num1} is equal to or greater than {Num2}");
                }

                Thread.Sleep(3000); 
                Num1 += 10; 
            }

            
            Console.ResetColor();
        }

       
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
using System;
using System.Threading; 

namespace CCXVI
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 90;
            int Num2 = 180;
            int Addsum = AddNumbers(Num1, Num2); 

            Console.WriteLine("hello");
            Console.WriteLine($"The sum of {Num1} + {Num2} = {Addsum}");

            while (Num1 <= Num2) 
            {
                if (Num1 < Num2)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine($"{Num1} is smaller than {Num2}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine($"{Num1} is equal to or greater than {Num2}");
                }

                Thread.Sleep(3000); 
                Num1 += 10; 
            }

            
            Console.ResetColor();
        }

       
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
