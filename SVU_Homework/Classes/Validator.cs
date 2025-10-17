using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVU_Homework.Classes
{
    public static class Validator
    {
        public static bool ValidateItem(LibraryItem item)
        {
            if (item == null)
            {
                Console.WriteLine(" Error: Item is null");
                return false;
            }

            if (string.IsNullOrWhiteSpace(item.Title))
            {
                Console.WriteLine(" Error: Invalid item title");
                return false;
            }

            if (string.IsNullOrWhiteSpace(item.Id))
            {
                Console.WriteLine(" Error: Invalid item ID");
                return false;
            }

            Console.WriteLine($" Validation passed for: {item.Title}");
            return true;
        }

        public static bool ValidateString(string input, int maxLength = 100)
        {
            return !string.IsNullOrWhiteSpace(input) && input.Length <= maxLength;
        }

        public static bool ValidateISBN(string isbn)
        {
            return !string.IsNullOrWhiteSpace(isbn) && isbn.Length >= 10;
        }
    }
}
