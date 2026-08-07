using Odev40_Constructor_LibraryMember.Models;

namespace Odev40_Constructor_LibraryMember.Models;

public class Program
{
    static void Main(string[] args)
    {
        LibraryMember libraryMember1 = new LibraryMember(1132, "Baran Kaya", new DateTime(2026, 06, 13));
        libraryMember1.BorrowedBookCount = 21;

        LibraryMember libraryMember2 = new LibraryMember(2483, "Hülya Al", new DateTime(2026, 04, 22));
        libraryMember2.BorrowedBookCount = 7;

        LibraryMember[] libraryMembers = { libraryMember1, libraryMember2 };

        Console.WriteLine("➕ KÜTÜPHANE ÜYE LİSTE ➕");

        foreach (LibraryMember libraryMember in libraryMembers)
        {
            Console.WriteLine($"Üye NO       : {libraryMember.MemberId}");
            Console.WriteLine($"Ad Soyad     : {libraryMember.FullName}");
            Console.WriteLine($"Üyelik Tipİ  : {libraryMember.MembershipType}");
            Console.WriteLine($"Kayıt Tarih : {libraryMember.RegistrationDate.ToShortDateString()}");
            Console.WriteLine($"Ödünç Kitap  : {libraryMember.BorrowedBookCount}");
            Console.WriteLine(new string('+', 30));
        }
    }
}