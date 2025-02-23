using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal;
            System.Console.WriteLine("Enter a number: ");

            if(int.TryParse(Console.ReadLine(), out theVal)){
                System.Console.WriteLine($"the value is {theVal}");

                // Now safely check the value
                if (theVal < 51){
                    System.Console.WriteLine($"the value {theVal} is less than 51");
                } else { 
                    System.Console.WriteLine($"the value {theVal} is greater than or equal to 51");
                }
            } 
            else {
                System.Console.WriteLine("The value is not an integer, please enter a valid number.");
            }

            // To do reverse logic task

            System.Console.WriteLine("Enter a string: ");
            string name = Console.ReadLine(); 
            string reverse =  string.Empty; // or string reverse = "";
            for (int i = name.Length - 1; i >= 0; i--){
                reverse += name[i];
            }
            System.Console.WriteLine($"The reverse of the string is: {reverse}");

            // -----------------------
            // TODO: Using the ternary operator ?:

            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: can be replaced by a ternary operator ?:
            System.Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");

        }
    }
}
