using _02_CampusLibraryApp.scr.Catalog;
using _02_CampusLibraryApp.scr.Interfaces;

namespace _02_CampusLibraryApp.scr.Infrastructure;

public class InMemoryBookRepository : IRepository<Book>
{
    private readonly List<Book> _books = new();

    public void Add(Book book)
    {
        if (_books.Any(x => x.BookId == book.BookId))
            throw new InvalidOperationException(
                $"'{book.BookId}' ID'li kitap zaten mevcut.");

        _books.Add(book);
    }

    public Book? GetById(string id)
    {
        return _books.FirstOrDefault(x => x.BookId == id);
    }

    public Book[] GetAll()
    {
        return _books.ToArray();
    }

    public void Delete(string id)
    {
        Book? book = GetById(id);

        if (book != null)
        {
            _books.Remove(book);
        }
    }
}