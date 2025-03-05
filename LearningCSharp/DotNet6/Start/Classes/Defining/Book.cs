using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string _title;
        string _author;
        int _pages;

        // TODO: classes have one or more constructors
        public Book(string title, string author, int pages)
        {
            _title = title;
            _author = author;
            _pages = pages;
        }


        // TODO: methods are used to operate on the class and data
        public string GetDescription()
        {
            return $"{_title} by {_author}, {_pages} pages";
        }

    }
}
