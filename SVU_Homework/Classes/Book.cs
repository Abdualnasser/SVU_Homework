using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Classes
{
    // Derived class 1: Book
    public class Book : LibraryItem
    {
        public string ISBN { get; private set; }
        public int PageCount { get; private set; }

        public Book(string id, string title, string author, string isbn, int pageCount)
            : base(id, title, author)
        {
            ISBN = isbn;
            PageCount = pageCount;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"   Book: {_title}");
            Console.WriteLine($"   Author: {_author}");
            Console.WriteLine($"   ISBN: {ISBN}");
            Console.WriteLine($"   Pages: {PageCount}");
            Console.WriteLine($"   Status: {(_isAvailable ? "Available" : "Borrowed")}");
            Console.WriteLine("   -------------------");
        }
    }
}
