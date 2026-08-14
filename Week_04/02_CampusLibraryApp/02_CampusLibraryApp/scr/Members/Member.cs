namespace _02_CampusLibraryApp.scr.Members;

public abstract class Member
{
    private readonly List<string> _borrowedBooks = new();

    public string MemberId { get; }

    public string FullName { get; }

    public bool IsActive { get; private set; }

    public DateTime CreatedAt { get; }

    public int BorrowedCount
    {
        get { return _borrowedBooks.Count; }
    }

    public IReadOnlyList<string> BorrowedBooks
    {
        get { return _borrowedBooks.AsReadOnly(); }
    }

    public abstract int MaxBooks { get; }

    public abstract int LoanPeriodDays { get; }

    public abstract decimal CalculateLateFee(int daysLate);

    public abstract string GetMemberType();

    protected Member(string memberId, string fullName)
    {
        if (string.IsNullOrWhiteSpace(memberId))
            throw new ArgumentException("Üye ID boş olamaz.");

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Üye adı boş olamaz.");

        MemberId = memberId;
        FullName = fullName;
        IsActive = true;
        CreatedAt = DateTime.Now;
    }

    public void AddBorrowedBook(string bookId)
    {
        if (!_borrowedBooks.Contains(bookId))
        {
            _borrowedBooks.Add(bookId);
        }
    }

    public void RemoveBorrowedBook(string bookId)
    {
        _borrowedBooks.Remove(bookId);
    }

    public bool HasBook(string bookId)
    {
        return _borrowedBooks.Contains(bookId);
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}