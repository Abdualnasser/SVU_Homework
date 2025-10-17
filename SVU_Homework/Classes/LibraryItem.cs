using SVU_Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Classes
{
    // Abstract base class
    public abstract class LibraryItem : ILibraryItem
    {
        // Private read-only field
        private readonly string _id;

        // Protected fields
        protected string _title;
        protected string _author;
        protected bool _isAvailable;

        // Encapsulated safe-access properties
        public string Id => _id;
        public string Title => _title;
        public string Author => _author;
        public bool IsAvailable => _isAvailable;

        // Protected constructor
        protected LibraryItem(string id, string title, string author)
        {
            _id = id;
            _title = title;
            _author = author;
            _isAvailable = true;
        }

        // Abstract method – must be implemented by derived classes
        public abstract void DisplayInfo();

        // Virtual methods – can be overridden
        public virtual void Borrow()
        {
            if (_isAvailable)
            {
                _isAvailable = false;
                Console.WriteLine($"Borrowed: {_title}");
            }
            else
            {
                Console.WriteLine($"Item '{_title}' is not available for borrowing.");
            }
        }

        public virtual void Return()
        {
            _isAvailable = true;
            Console.WriteLine($"Returned: {_title}");
        }
    }
}
