using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output information using formatting
            System.Console.WriteLine("Output information using formatting");
            System.Console.WriteLine("This car is a {0} {1} from {2}.", make, model, year);
            System.Console.WriteLine("It has {0:F2} miles on it and costs {1:C}.", miles, price);

            // TODO: Using string interpolation
            System.Console.WriteLine("Using string interpolation");
            System.Console.WriteLine($"This car is a {make} {model} from {year}.");
            System.Console.WriteLine($"It has {miles:F2} miles on it and costs {price:C}.");


            // TODO: With inline expressions
            System.Console.WriteLine("With inline expressions");
            System.Console.WriteLine($"This car is a {make} {model} from {year}.");
            System.Console.WriteLine($"It has {miles * 1.6:F2} kilometers on it and costs {price:C}.");            
        }
    }
}
