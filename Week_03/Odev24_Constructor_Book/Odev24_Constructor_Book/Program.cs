namespace Odev24_Book.Models;


class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.Name = "Beyaz Diş";
        book1.AuthorName = "Jack London";
        book1.PageCount = 320;

        Book book2 = new Book("Kürk Mantolu Madonna");
        book2.AuthorName = "Sabahattin Ali";
        book2.PageCount=325;

        Book book3 = new Book("Sefiller", "Victor Hugo");
        book3.PageCount = 1488;

        Book book4 = new Book("Harry Potter ve Felsefe Taşı", "J.K. Rowling", "Fantastik");
        book4.PageCount = 336;

        Book book5 = new Book("Nutuk", "Mustafa Kemal Atatürk", "Tarih", 543);

        Console.WriteLine($"1. Kitap → Ad: {book1.Name} | Yazar: {book1.AuthorName} | Sayfa Sayısı: {book1.PageCount}");
        Console.WriteLine($"2. Kitap → Ad: {book2.Name} | Yazar: {book2.AuthorName} | Sayfa Sayısı: {book2.PageCount}");
        Console.WriteLine($"3. Kitap → Ad: {book3.Name} | Yazar: {book3.AuthorName} | Sayfa Sayısı: {book3.PageCount}");
        Console.WriteLine($"4. Kitap → Ad: {book4.Name} | Yazar: {book4.AuthorName} | Sayfa Sayısı: {book4.PageCount}");
        Console.WriteLine($"5. Kitap → Ad: {book5.Name} | Yazar: {book5.AuthorName} | Sayfa Sayısı: {book5.PageCount}");
    }
}

