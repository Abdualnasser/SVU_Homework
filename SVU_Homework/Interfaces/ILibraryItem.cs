using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Interfaces
{
    public interface ILibraryItem
    {
        string Title { get; }
        string Author { get; }
        bool IsAvailable { get; }
        void DisplayInfo();
    }
}
