using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Functions can provide default values for their parameters
        void PrintWithPrefix(string thestr, string prefix = "Default")
        {
            Console.WriteLine($"{prefix} {thestr}");
        }       
        // TODO: Test the default parameters
        PrintWithPrefix("Hello");
        PrintWithPrefix("Hello", "Custom");

        // TODO: Call with named params
        PrintWithPrefix(prefix: "Named", thestr: "Hello");

    }
}



