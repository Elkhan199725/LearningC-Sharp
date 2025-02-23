using System;
using System.Diagnostics;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int theVal)){
                System.Console.WriteLine($"the value is {theVal}");
            }
            else {
                System.Console.WriteLine("The value is not an integer, please enter a valid number.");
                return;
            }

            // Using the switch statement
            switch (theVal){
                case 1:
                    System.Console.WriteLine("The value is 1");
                    break;
                case 2:
                    System.Console.WriteLine("The value is 2");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("The value is 3,4, or 5");
                    break;
                default:
                    System.Console.WriteLine("The value is not 1, 2, 3, 4, or 5");
                    break;
            }
        }
    }
}
