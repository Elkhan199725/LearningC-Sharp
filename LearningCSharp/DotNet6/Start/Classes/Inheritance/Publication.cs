using System;

namespace Inheritance
{
    class Publication
    {
        private string _name; // backing field for the Name property

        public Publication(string name, int pagecount, decimal price) {
           _name = name;
           PageCount = pagecount;
           Price = price;
        }

        // The PageCount property has no backing field
        public int PageCount {  // auto-implemented property
            get; set;
        }

        public decimal Price {  // auto-implemented property
            get; set;
        }

        public string Name {
            // return the name
            get { return _name; }
            
            // use the setter to validate the new property value
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                if (value.Length > 30) {
                    throw new ArgumentException("Name cannot be more than 30 characters");
                }
                _name = value;
            }
        }

        // TODO: use the "virtual" keyword to indicate that a method
        // can be overridden by subclasses to customize behavior
        public virtual string GetPublicationInfo() {
            return $"Publication: {Name}, Pages: {PageCount}";
        }   

    }
}