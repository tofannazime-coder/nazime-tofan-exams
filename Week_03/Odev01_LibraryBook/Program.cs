using System;

namespace Odev01_LibraryBook.Models;

class Program
{
    static Book book = new Book("Sefiller","Victor Hugo",false);
    
    static void Main(string[] args)
    {
    borrow();
    borrow();
    returnBook();
    borrow();

    }
    public static void borrow()
    {
        
        if (book.IsAvailable == true)
        {
           Console.WriteLine("Kitap müsait alınabilir.");
        } else
        {
           Console.WriteLine("Kitap müsait değil.");
        }
    }
    public static void returnBook()
    {
       book.IsAvailable = true;
    }


}
