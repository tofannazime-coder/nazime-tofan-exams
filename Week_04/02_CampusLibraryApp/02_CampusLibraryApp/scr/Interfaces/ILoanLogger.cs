namespace _02_CampusLibraryApp.scr.Interfaces;

public interface ILoanLogger
{
    void Log(
        string memberId,
        string bookId,
        string operation,
        string details);

    string[] GetHistory(string memberId);
}