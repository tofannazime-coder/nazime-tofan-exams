using _02_CampusLibraryApp.scr.Catalog;
using _02_CampusLibraryApp.scr.Interfaces;
using _02_CampusLibraryApp.scr.Members;

namespace _02_CampusLibraryApp.scr.Services;

public class LibraryService
{
    private readonly IRepository<Member> _memberRepo;
    private readonly IRepository<Book> _bookRepo;
    private readonly ILoanLogger _logger;

    private readonly List<string> _renewedKeys = new();

    public LibraryService(
        IRepository<Member> memberRepo,
        IRepository<Book> bookRepo,
        ILoanLogger logger)
    {
        _memberRepo = memberRepo;
        _bookRepo = bookRepo;
        _logger = logger;
    }

    public void RegisterMember(Member member)
    {
        _memberRepo.Add(member);

        _logger.Log(
            member.MemberId,
            "-",
            "KAYIT",
            $"Yeni {member.GetMemberType()} üye eklendi.");
    }

    public void AddBook(Book book)
    {
        _bookRepo.Add(book);

        _logger.Log(
            "-",
            book.BookId,
            "KİTAP EKLE",
            $"'{book.Title}' stoğa eklendi.");
    }

    public bool Borrow(string memberId, string bookId)
    {
        Member member = GetActiveMemberOrThrow(memberId);
        Book book = GetBookOrThrow(bookId);

        if (book.AvailableCopies <= 0)
        {
            _logger.Log(
                memberId,
                bookId,
                "RED",
                "Kitap stokta yok.");

            return false;
        }

        if (member.BorrowedCount >= member.MaxBooks)
        {
            _logger.Log(
                memberId,
                bookId,
                "RED",
                $"Üye kitap limitine ulaştı. Limit: {member.MaxBooks}");

            return false;
        }

        book.BorrowOne();
        member.AddBorrowedBook(bookId);

        _logger.Log(
            memberId,
            bookId,
            "ÖDÜNÇ",
            $"Ödünç süresi: {member.LoanPeriodDays} gün.");

        return true;
    }

    public bool Return(
        string memberId,
        string bookId,
        DateTime? returnDate = null)
    {
        Member member = GetActiveMemberOrThrow(memberId);
        Book book = GetBookOrThrow(bookId);

        if (!member.HasBook(bookId))
        {
            _logger.Log(
                memberId,
                bookId,
                "RED",
                "Üye bu kitabı ödünç almamış.");

            return false;
        }

        DateTime actualReturnDate =
            returnDate ?? DateTime.Today;

        // Test amacıyla kitabın bugün değil,
        // LoanPeriodDays + 5 gün önce alındığını varsayıyoruz.
        DateTime borrowedDate =
            DateTime.Today.AddDays(
                -(member.LoanPeriodDays + 5));

        int daysHeld =
            (actualReturnDate - borrowedDate).Days;

        int daysLate =
            daysHeld - member.LoanPeriodDays;

        if (daysLate < 0)
            daysLate = 0;

        decimal lateFee =
            member.CalculateLateFee(daysLate);

        member.RemoveBorrowedBook(bookId);
        book.ReturnOne();

        _logger.Log(
            memberId,
            bookId,
            "İADE",
            $"Gecikme: {daysLate} gün | Ceza: {lateFee:C2}");

        return true;
    }

    public bool Renew(string memberId, string bookId)
    {
        Member member = GetActiveMemberOrThrow(memberId);
        Book book = GetBookOrThrow(bookId);

        if (!member.HasBook(bookId))
        {
            _logger.Log(
                memberId,
                bookId,
                "RED",
                "Üye bu kitabı ödünç almamış.");

            return false;
        }

        string key = $"{memberId}_{bookId}";

        if (_renewedKeys.Contains(key))
        {
            _logger.Log(
                memberId,
                bookId,
                "RED",
                "Kitap daha önce uzatılmış.");

            return false;
        }

        _renewedKeys.Add(key);

        _logger.Log(
            memberId,
            bookId,
            "UZATMA",
            $"+{member.LoanPeriodDays} gün uzatıldı.");

        return true;
    }

    public void PrintMemberList()
    {
        Console.WriteLine("\n=== ÜYE LİSTESİ ===");

        Member[] members = _memberRepo.GetAll();

        foreach (Member member in members)
        {
            Console.WriteLine(
                $"ID: {member.MemberId} | " +
                $"İsim: {member.FullName} | " +
                $"Tip: {member.GetMemberType()} | " +
                $"Kitap: {member.BorrowedCount}/{member.MaxBooks} | " +
                $"Durum: {(member.IsActive ? "Aktif" : "Pasif")}");
        }
    }

    public void PrintBookList()
    {
        Console.WriteLine("\n=== KİTAP LİSTESİ ===");

        Book[] books = _bookRepo.GetAll();

        foreach (Book book in books)
        {
            Console.WriteLine(
                $"ID: {book.BookId} | " +
                $"Kitap: {book.Title} | " +
                $"Stok: {book.AvailableCopies}/{book.TotalCopies}");
        }
    }

    public void PrintHistory(string memberId)
    {
        Console.WriteLine(
            $"\n=== İŞLEM GEÇMİŞİ: {memberId} ===");

        string[] logs =
            _logger.GetHistory(memberId);

        foreach (string log in logs)
        {
            Console.WriteLine(log);
        }
    }

    private Member GetActiveMemberOrThrow(string memberId)
    {
        Member? member =
            _memberRepo.GetById(memberId);

        if (member == null)
        {
            throw new KeyNotFoundException(
                $"'{memberId}' ID'li üye bulunamadı.");
        }

        if (!member.IsActive)
        {
            throw new InvalidOperationException(
                $"'{memberId}' ID'li üye pasif.");
        }

        return member;
    }

    private Book GetBookOrThrow(string bookId)
    {
        Book? book =
            _bookRepo.GetById(bookId);

        if (book == null)
        {
            throw new KeyNotFoundException(
                $"'{bookId}' ID'li kitap bulunamadı.");
        }

        return book;
    }
}