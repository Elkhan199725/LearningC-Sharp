using System;
using System.Linq;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

            // TODO: Length of a string
            int len1 = str1.Length; // Length is a property, not a method call
            Console.WriteLine($"The length of the string is {len1}");

            // TODO: Access individual characters
            char c1 = str1[14]; // 0-based index into the string to get the character at that position
            Console.WriteLine($"The character at position 14 is {c1}");

            // TODO: iterate over a string like any other sequence of values
            foreach (char c in str1){
                Console.Write($"{c}");
                if (c == 'n') break;                
            }
            System.Console.WriteLine("\nhit the break");

            // TODO: String Concatenation (concatenation does not support adding separators but select operator can be used)
            outstr = String.Concat(strs.Select(s => s + " ")); // Concatenate all the strings in the array with a space between them
            Console.WriteLine($"Concatenated string is '{outstr}'");
            // TODO: Joining strings together with Join
            outstr = String.Join(String.Empty, strs); // Join all the strings in the array with no separator
            Console.WriteLine($"Joined string is '{outstr}'");

            outstr = String.Join(" ", strs); // Join all the strings in the array with a space separator
            Console.WriteLine($"Joined string is '{outstr}'");

            // TODO: String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            System.Console.WriteLine("String Comparison");
            int result = String.Compare(str2, str3, StringComparison.OrdinalIgnoreCase); // Compare the two strings ignoring case
            Console.WriteLine($"Comparison result is {result}");
            int result2 = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase); // Compare the two strings ignoring case
            Console.WriteLine($"Comparison result is {result2}");

            // TODO: Equals just returns a regular Boolean
            System.Console.WriteLine("String Equals");
            bool areEqual = str2.Equals(str3, StringComparison.OrdinalIgnoreCase); // Compare the two strings ignoring case
            Console.WriteLine($"The two strings are equal: {areEqual}");
            bool areEqual2 = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // Compare the two strings ignoring case
            Console.WriteLine($"The two strings are equal: {areEqual2}");

            // TODO: String Searching
            System.Console.WriteLine("String Searching");
            int idx1 = str1.IndexOf('e'); // Find the first occurrence of the character 'e'
            Console.WriteLine($"The first 'e' is at position {idx1}");
            int idx2 = str1.IndexOf("fox"); // Find the first occurrence of the string "fox"
            Console.WriteLine($"The word 'fox' starts at position {idx2}");
            int idx3 = str1.LastIndexOf('e'); // Find the last occurrence of the character 'e'
            Console.WriteLine($"The last 'e' is at position {idx3}");
            outstr = str1.Replace("fox", "tiger"); // Replace all occurrences of "fox" with "tiger"
            Console.WriteLine($"Replaced string is '{outstr}'");
            System.Console.WriteLine(outstr.IndexOf("fox")); // -1 means not found
            System.Console.WriteLine(outstr.IndexOf("tiger")); // 16 means found
        }
    }
}
