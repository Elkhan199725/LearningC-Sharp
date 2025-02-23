using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            System.Console.WriteLine("----- Variables -----");
            int a = 10;
            int b = 3;
            int c = 0;
            int? d = null;
            string s = "Hello";
            string t = null;
            bool x = true;
            bool y = false;
            System.Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, s: {s}, t: {t}, x: {x}, y: {y}");

            // TODO: Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");

            var result = ((a + b) * c)/b;
            Console.WriteLine($"Result: {result}");

            // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            a++;
            b--;
            Console.WriteLine($"a: {a}, b: {b}");


            // TODO: Operators can be shorthand: a = a + b
            Console.WriteLine("----- Shorthand -----");
            a += b;
            a -= b;
            a *= b;
            a /= b;
            a %= b;
            Console.WriteLine($"a: {a}");


            // TODO: Logical operators &&, ||
            Console.WriteLine("----- Logic Operators -----");
            Console.WriteLine($"AND: {a>b && a<c}");
            Console.WriteLine($"OR: {a>b || a<c}");
            System.Console.WriteLine($"NOT: {!x}");


            // null-coalescing operators
            Console.WriteLine("----- Null Coalescing -----");
            string nullValue = null;

            // TODO: the ?? operator uses left operand if not null, or right one if it is
            string value = nullValue ?? "default";
            Console.WriteLine($"Value: {value}");
            
            // TODO: the ??= operator assigns the right operand if the left one is null
            nullValue ??= "new value";
            Console.WriteLine($"Null Value: {nullValue}");

        }
    }
}
