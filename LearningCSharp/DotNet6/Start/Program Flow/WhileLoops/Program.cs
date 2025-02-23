using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = string.Empty;

            // TODO: basic while loop executes while the gate condition is true
            Console.WriteLine("Basic while() loop:");
            while (inputStr != "quit"){
                System.Console.WriteLine("Enter a string (or 'quit' to exit): ");
                inputStr = Console.ReadLine();
                System.Console.WriteLine($"You entered: {inputStr}");
                break;
            }

            Console.WriteLine();

            // TODO: the do-while loop always executes at least one time
            Console.WriteLine("The  do-while() loop:");
            do {
                System.Console.WriteLine("Enter a string (or 'quit' to exit): ");
                inputStr = Console.ReadLine();
                System.Console.WriteLine($"You entered: {inputStr}");
            }while (inputStr != "quit");

            Console.WriteLine();
        }
    }
}
