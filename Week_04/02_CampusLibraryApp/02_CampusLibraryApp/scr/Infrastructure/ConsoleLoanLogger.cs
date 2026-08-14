using _02_CampusLibraryApp.scr.Interfaces;

namespace _02_CampusLibraryApp.scr.Infrastructure;

public class ConsoleLoanLogger : ILoanLogger
{
    private readonly List<string> _logs = new();

    public void Log(
        string memberId,
        string bookId,
        string operation,
        string details)
    {
        string log =
            $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} | " +
            $"Üye: {memberId} | " +
            $"Kitap: {bookId} | " +
            $"{operation} | " +
            $"{details}";

        _logs.Add(log);

        Console.WriteLine(log);
    }

    public string[] GetHistory(string memberId)
    {
        return _logs
            .Where(x => x.Contains($"Üye: {memberId}"))
            .ToArray();
    }
}