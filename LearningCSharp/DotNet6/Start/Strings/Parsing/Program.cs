using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // We'll use these strings to try and parse numbers
            System.Console.WriteLine("Enter a number: ");
            string numStr1 = Console.ReadLine();
            System.Console.WriteLine("You entered: " + numStr1);
            System.Console.WriteLine("Enter a number: ");
            string numStr2 = Console.ReadLine();
            System.Console.WriteLine("You entered: " + numStr2);
            System.Console.WriteLine("Enter a number: ");
            string numStr3 = Console.ReadLine();
            System.Console.WriteLine("You entered: " + numStr3);
            System.Console.WriteLine("Enter a number: ");
            string numStr4 = Console.ReadLine();
            System.Console.WriteLine("You entered: " + numStr4);
            char[] separators = {',', '.'}; // This is a list of separators we'll use later

            // The Parse function attempts to parse a string into a number
            // but it might throw an exception, so we need to catch that
            int targetNum;
            try {
                // TODO: Use Parse to try a simple integer
                targetNum = int.Parse(numStr1, NumberStyles.Integer, CultureInfo.InvariantCulture);
                Console.WriteLine($"{targetNum}");

                // TODO: Use Parse to try a floating point number
                // This only works if the decimal value is 0
                targetNum = int.Parse(numStr2, NumberStyles.Float, CultureInfo.InvariantCulture);
                Console.WriteLine($"{targetNum}");

                // TODO: Use Parse to try a number with thousands marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands, CultureInfo.InvariantCulture);
                Console.WriteLine($"{targetNum}");

                // TODO: Use Parse to try a number with thousands marker AND decimal
                targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float, CultureInfo.InvariantCulture);
                Console.WriteLine($"{targetNum}");

                // TODO: This works with other types too, like bool
                bool targetBool = bool.Parse("true");
                Console.WriteLine($"{targetBool}");

                // TODO: Or floating point numbers
                double targetDouble = double.Parse("3.14", NumberStyles.Float, CultureInfo.InvariantCulture);
                Console.WriteLine($"{targetDouble}");
                
            }
            catch {
                Console.WriteLine("Conversion failed");
            }

            // TODO: The TryParse function is similar but handles the exceptions for us
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("TryParse");
            bool succeeded = false;
            succeeded = int.TryParse(numStr1, out targetNum);
            if (succeeded) {
                Console.WriteLine($"Parsing succeeded! The number is: {targetNum}");
            }
            else {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
