using SVU_Homework.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Classes
{
    // Library class with events
    public class Library
    {
        private List<LibraryItem> _items;

        // Static property
        public static int TotalItems { get; private set; }

        // Events
        public event LibraryEventHandler OnItemBorrowed;
        public event LibraryEventHandler OnItemReturned;

        public Library()
        {
            _items = new List<LibraryItem>();
        }

        public void AddItem(LibraryItem item)
        {
            if (item != null && Validator.ValidateItem(item))
            {
                _items.Add(item);
                TotalItems++;
                Console.WriteLine($"Added: {item.Title}");
            }
        }

        public void BorrowItem(string itemId)
        {
            var item = FindItemById(itemId);
            if (item != null && item.IsAvailable)
            {
                item.Borrow();
                OnItemBorrowed?.Invoke(this, new LibraryEventArgs(item));
            }
        }

        public void ReturnItem(string itemId)
        {
            var item = FindItemById(itemId);
            if (item != null && !item.IsAvailable)
            {
                item.Return();
                OnItemReturned?.Invoke(this, new LibraryEventArgs(item));
            }
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("\n All Library Items:");
            Console.WriteLine("======================");
            foreach (var item in _items)
            {
                item.DisplayInfo(); // Polymorphism in action
            }
        }

        public List<LibraryItem> GetAvailableItems()
        {
            return _items.FindAll(item => item.IsAvailable);
        }

        private LibraryItem FindItemById(string id)
        {
            return _items.Find(item => item.Id == id);
        }
    }
}
