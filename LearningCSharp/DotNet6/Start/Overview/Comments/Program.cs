using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            public static bool IsPrime(int number)
            {
                if (number < 2) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            // Usage Example
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} is {(IsPrime(num) ? "Prime" : "Not Prime")}");

        }
    }
}
