using SVU_Homework.Classes;

Console.WriteLine(" Library Management System - Starting");
Console.WriteLine("========================================\n");

// Create library
Library library = new Library();

// Subscribe to events
library.OnItemBorrowed += (sender, e) =>
{
    Console.WriteLine($"\n Event: '{e.Item.Title}' was borrowed at {e.EventTime:HH:mm:ss}");
};

library.OnItemReturned += (sender, e) =>
{
    Console.WriteLine($"\n Event: '{e.Item.Title}' was returned at {e.EventTime:HH:mm:ss}");
};

// Create various items
Book book1 = new Book("B001", "Learning C# Programming", "Ahmed Mohamed", "978-1234567890", 350);
Book book2 = new Book("B002", "System Design Principles", "Fatima Ali", "978-0987654321", 280);
Magazine magazine = new Magazine("M001", "Science & Technology", "Research Center", "ISSUE-2024-10", new DateTime(2024, 10, 1));
DVD dvd = new DVD("D001", "ASP.NET Core Course", "Tech Institute", new TimeSpan(2, 30, 0));

// Add items to library
library.AddItem(book1);
library.AddItem(book2);
library.AddItem(magazine);
library.AddItem(dvd);

// Display all items
library.DisplayAllItems();

// Test borrowing
Console.WriteLine("\n Testing Borrow Operations:");
Console.WriteLine("============================");
library.BorrowItem("B001"); // Borrow book
library.BorrowItem("M001"); // Borrow magazine

// Show available items after borrowing
Console.WriteLine("\n Available Items After Borrowing:");
Console.WriteLine("==================================");
var availableItems = library.GetAvailableItems();
foreach (var item in availableItems)
{
    item.DisplayInfo();
}

// Test returning
Console.WriteLine("\n Testing Return Operations:");
Console.WriteLine("============================");
library.ReturnItem("B001");

// Final stats
Console.WriteLine("\n Final Statistics:");
Console.WriteLine("===================");
Console.WriteLine($"Total items in system: {Library.TotalItems}");
Console.WriteLine($"Currently available: {availableItems.Count}");

// Test validator
Console.WriteLine("\n Testing Validation:");
Console.WriteLine("=====================");
Console.WriteLine($"ISBN validation: {Validator.ValidateISBN("9781234567890")}");
Console.WriteLine($"String validation: {Validator.ValidateString("Sample text")}");

Console.WriteLine("\n Program executed successfully!");
