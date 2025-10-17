using SVU_Homework.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Events
{
    public delegate void LibraryEventHandler(object sender, LibraryEventArgs e);
    public class LibraryEventArgs : EventArgs
    {
        public LibraryItem Item { get; }
        public DateTime EventTime { get; }

        public LibraryEventArgs(LibraryItem item)
        {
            Item = item;
            EventTime = DateTime.Now;
        }
    }
}
