using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // TODO: create a StringBuilder
            StringBuilder builder = new StringBuilder("Initial content", 256);
            
            // TODO: print some basic stats about the StringBuilder
            System.Console.WriteLine($"Capacity: {builder.Capacity}, Length: {builder.Length}");

            // TODO: Add some strings to the builder using Append
            builder.Append(" - ");
            builder.Append("The quick brown fox");
            builder.Append(" - ");
            builder.Append("jumped over the lazy dog");

            // TODO: AppendLine can append a line ending
            builder.AppendLine();
            builder.AppendLine("This is a new line");

            // TODO: AppendFormat can be used to append formatted strings
            builder.AppendFormat("He did this {0} times", jumpCount);
            builder.AppendLine();

            // TODO: AppendJoin can iterate over a set of values
            builder.Append("He also jumped over ");
            builder.AppendJoin(", ", animals);
            builder.AppendLine();

            // TODO: Modify the content using Replace
            builder.Replace("fox", "wolf");

            // TODO: Insert content at any index
            builder.Insert(0, "This is the ");
            
            // TODO: Convert to a single string
            System.Console.WriteLine($"Capacity: {builder.Capacity}, Length: {builder.Length}");
            System.Console.WriteLine(builder.ToString());

        }
    }
}
