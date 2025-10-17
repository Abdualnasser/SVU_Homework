using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Classes
{
    public class DVD : LibraryItem
    {
        public string Director { get; private set; }
        public TimeSpan Duration { get; private set; }

        public DVD(string id, string title, string director, TimeSpan duration)
            : base(id, title, director) // Use director as "author"
        {
            Director = director;
            Duration = duration;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"   DVD: {_title}");
            Console.WriteLine($"   Director: {Director}");
            Console.WriteLine($"   Duration: {Duration:mm\\:ss} minutes");
            Console.WriteLine($"   Status: {(_isAvailable ? "Available" : "Borrowed")}");
            Console.WriteLine("   -------------------");
        }
    }
}

