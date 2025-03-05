using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples are grouped values added in C# 7
            (string, int) person = ("John", 25);// Tuple literal
            Console.WriteLine(person.Item1); // John
            Console.WriteLine(person.Item2); // 25
            var person2 = (Name: "John", Age: 25); // Tuple literal with named fields
            Console.WriteLine(person2.Name); // John
            Console.WriteLine(person2.Age); // 25

            // TODO: Tuple values are mutable
            person.Item1 = "Jane";
            Console.WriteLine(person.Item1); // Jane
            person2.Name = "Eva";
            Console.WriteLine(person2.Name); // Evas

            // TODO: Functions can work with tuples
            int[] numbers = { 51, 22, 23, 54, 34 };
            var result = GetMinMax(numbers);
            Console.WriteLine($"Min: {result.Item1}, Max: {result.Item2}"); // Min: 1, Max: 5
            
        }

        // TODO: Functions can return multiple values using tuples
        static (int, int) GetMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            return (min, max);
        }

    }
}
