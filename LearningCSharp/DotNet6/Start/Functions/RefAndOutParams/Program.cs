using System;

namespace RefAndOutParams {
    class Program {
        // TODO: Ordinary value arguments cannot be modified by the function
        // because they are a copy of the original value        
        static void TestFunc1(int arg1) {
            arg1 += 10;
        }

        // TODO: Arguments that are passed by reference can be modified
        // by the function and reflected back to the caller
        static void TestFunc2(ref int arg1) {
            arg1 += 10;
        }

        // TODO: The "out" keyword means that the parameter returns a value and is not
        // used to supply data to the function
        static void PlusTimes(int arg1, int arg2, out int sum, out int product) {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        static void Main(string[] args) {
            int val1 = 10;
            int val2 = 20;

            // Functions don't normally modify value arguments
            Console.WriteLine("This is the value of val1 before the function call: " + val1);
            TestFunc1(val1);
            Console.WriteLine("This is the value of val1 after the function call: " + val1);

            // TODO: Using the "ref" keyword, arguments can be passed by reference
            // which allows the function to modify them
            Console.WriteLine("This is the value of val2 before the function call: " + val2);
            TestFunc2(ref val2);
            Console.WriteLine("This is the value of val2 after the function call: " + val2);

            // TODO: The "out" keyword can be used to indicate that an argument
            // is intended to return a value and is not an input
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            PlusTimes(num1, num2, out int sum, out int product);
            Console.WriteLine($"Sum: {sum}, Product: {product}");
        }
    }
}
