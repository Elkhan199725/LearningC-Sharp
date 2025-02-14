using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';
            System.Console.WriteLine("These are some basic value types: {0}, {1}, {2}, {3}, {4}", i, f, d, b, c); // Composite Formatting
            System.Console.WriteLine($"These are some basic value types: {i}, {f}, {d}, {b}, {c}"); // String Interpolation

            // Declare a string - it's a collection of characters
            string stringValue = "a string";
            System.Console.WriteLine($"The value of stringValue is {stringValue}");
            System.Console.WriteLine($"The fourth character of stringValue is {stringValue[3]}");

            // Declare an implicit variable
            var num1 = 10;
            var word1 = "Hello!";
            System.Console.WriteLine($"The value of num1 is {num1} and word1 is {word1}"); // String Interpolation

            // TODO: Declare an array of values
            int[] numbers = {10, 20, 30, 55, 120, 200, 204, 209, 250}; // Array of integers
            string[] words = {"one", "two", "three", "four", "five"}; // Array of strings

            // TODO: Print the values using a Formatting String
            System.Console.WriteLine($"In numbers the value of third index is {numbers[2]}");
            System.Console.WriteLine($"In words the value of  first index is {words[0]}");

            // TODO: "null" means "no value"
            int? nullableInt = null;
            System.Console.WriteLine($"Nullable int is {nullableInt}"); 

            // TODO: Implicit conversion between types
            int a = 10;
            double e = a;
            System.Console.WriteLine($"The value of a is {a}");
            System.Console.WriteLine($"Implicit conversion from int to double: {e:F3}"); // Formatting String

            // TODO: Explicit conversions
            double g = 10.5;
            int h = (int)g;
            System.Console.WriteLine($"The value of g is {g}");
            System.Console.WriteLine($"Explicit conversion from double to int: {h}"); // Formatting String

        }
    }
}
