using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers to divide:");

            string inputX = Console.ReadLine();
            string inputY = Console.ReadLine();

            try
            {
                if (!int.TryParse(inputX, out int x) || !int.TryParse(inputY, out int y))
                {
                    throw new FormatException("Invalid input. Please enter valid integers.");
                }

                double result = (double)x / y;

                if (double.IsInfinity(result))
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
