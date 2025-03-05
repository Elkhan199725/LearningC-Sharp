using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);
            Book book2 = new Book("The Catcher in the Rye", "J.D. Salinger", 230);
            
            // TODO: Call a method on the object
            Console.WriteLine(book.GetDescription());
            Console.WriteLine(book2.GetDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error

        }
    }
}
