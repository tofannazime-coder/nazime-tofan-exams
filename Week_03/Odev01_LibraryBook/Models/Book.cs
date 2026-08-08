using System;

namespace Odev01_LibraryBook.Models;

public class Book
{
    public String Title { get; set; }
    public String Author { get; set; }
    public bool IsAvailable { get; set; }
    
    public Book(string title, string author, bool isAvailable)
    {
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
}
