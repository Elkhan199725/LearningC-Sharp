using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Every class in C# inherits from Object, which means
            // that every class inherits the ToString() method
            int x = 42;
            Console.WriteLine(x.ToString());


            // TODO: if you don't override the method, the default behavior just prints
            // the name of the class and the namespace
            object o = new object();
            Console.WriteLine(o.ToString());


            // TODO: use the ToString method on the Book class
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Console.WriteLine(b1.ToString());
            
        }
    }
}
