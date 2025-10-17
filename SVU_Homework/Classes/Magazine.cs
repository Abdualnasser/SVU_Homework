using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Classes
{
    
    public class Magazine : LibraryItem
    {
        public string IssueNumber { get; private set; }
        public DateTime PublicationDate { get; private set; }

        public Magazine(string id, string title, string author, string issueNumber, DateTime publicationDate)
            : base(id, title, author)
        {
            IssueNumber = issueNumber;
            PublicationDate = publicationDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"   Magazine: {_title}");
            Console.WriteLine($"   Publisher: {_author}");
            Console.WriteLine($"   Issue: {IssueNumber}");
            Console.WriteLine($"   Published: {PublicationDate:yyyy-MM-dd}");
            Console.WriteLine($"   Status: {(_isAvailable ? "Available" : "Borrowed")}");
            Console.WriteLine("   -------------------");
        }
    }
}
