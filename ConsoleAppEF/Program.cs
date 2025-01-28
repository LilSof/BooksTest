using ConsoleAppEF.DataAccess;
using ConsoleAppEF.DBContext;
using Entities.Models;

var bookAccess = new BookAccess();
var userBooks = bookAccess.GetUserBooksWithBookInfo();

// Display the retrieved data
foreach (var userBook in userBooks)
{
    Console.WriteLine($"Book: {userBook.BookName} by {userBook.Author}");
    Console.WriteLine($"Progress: {userBook.IsReadPercentage}%");
    Console.WriteLine($"Current Page: {userBook.CurrentPage}/{userBook.NumberOfPages}");
    Console.WriteLine($"Added At: {userBook.AddedAt}");
    Console.WriteLine();
}

Console.WriteLine("Data retrieval complete!");