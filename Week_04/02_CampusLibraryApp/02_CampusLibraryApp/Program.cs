using _02_CampusLibraryApp.scr.Catalog;
using _02_CampusLibraryApp.scr.Infrastructure;
using _02_CampusLibraryApp.scr.Interfaces;
using _02_CampusLibraryApp.scr.Members;
using _02_CampusLibraryApp.scr.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ==============================
        // BAĞIMLILIKLAR
        // ==============================

        IRepository<Member> memberRepo =
            new InMemoryMemberRepository();

        IRepository<Book> bookRepo =
            new InMemoryBookRepository();

        ILoanLogger logger =
            new ConsoleLoanLogger();

        LibraryService libraryService =
            new LibraryService(
                memberRepo,
                bookRepo,
                logger);

        Console.WriteLine(
            "**** KAMPÜS KÜTÜPHANESİ ****\n");


        // ==============================
        // 1. ÜYE KAYITLARI
        // ==============================

        Console.WriteLine("--- ÜYE KAYITLARI ---");

        libraryService.RegisterMember(
            new StudentMember(
                "M101",
                "Musa Kaya"));

        libraryService.RegisterMember(
            new StudentMember(
                "M102",
                "Evin Tofan"));

        libraryService.RegisterMember(
            new AcademicMember(
                "M103",
                "Dr. Sedat Kran"));

        // Genişletme A - GuestMember
        libraryService.RegisterMember(
            new GuestMember(
                "M104",
                "Kübra Can"));


        // ==============================
        // 2. KİTAP EKLEME
        // ==============================

        Console.WriteLine("\n--- KİTAP EKLEMELERİ ---");

        libraryService.AddBook(
            new Book(
                "B101",
                "C# ile Nesne Yönelimli Programlama",
                "Ahmet Can",
                2));

        libraryService.AddBook(
            new Book(
                "B102",
                "Veri Yapıları",
                "Ayşe Akgün",
                1));

        libraryService.AddBook(
            new Book(
                "B103",
                "Yazılım Mimarileri",
                "Buse Koç",
                3));


        // ==============================
        // 3. BAŞARILI ÖDÜNÇLER
        // ==============================

        Console.WriteLine(
            "\n--- BAŞARILI ÖDÜNÇLER ---");

        // M101 öğrenci
        libraryService.Borrow("M101", "B101");
        libraryService.Borrow("M101", "B102");
        libraryService.Borrow("M101", "B103");

        // M102 öğrenci
        libraryService.Borrow("M102", "B101");

        // M103 akademisyen
        libraryService.Borrow("M103", "B103");


        // ==============================
        // 4. ÖĞRENCİ 4. KİTAP TESTİ
        // ==============================

        Console.WriteLine(
            "\n--- ÖĞRENCİ LİMİT TESTİ ---");

        Console.WriteLine(
            "M101 öğrencisi 4. kitabı almaya çalışıyor:");

        // M101'in zaten 3 kitabı var.
        // Bu nedenle reddedilmeli.
        libraryService.Borrow("M101", "B103");


        // ==============================
        // 5. STOK TESTİ
        // ==============================

        Console.WriteLine(
            "\n--- STOK TESTİ ---");

        Console.WriteLine(
            "B101 kitabının tüm kopyaları ödünçte:");

        // B101'in 2 kopyası vardı.
        // M101 ve M102 aldı.
        // Bu yüzden M103 alamamalı.
        libraryService.Borrow("M103", "B101");


        // ==============================
        // 6. GECİKMELİ İADE
        // ==============================

        Console.WriteLine(
            "\n--- GECİKMELİ İADE ---");

        // M101 öğrenci.
        // Öğrencinin süresi 14 gün.
        // LibraryService test amacıyla 5 gün gecikme hesaplıyor.
        // Ceza = 5 x 5 = 25 TL
        libraryService.Return(
            "M101",
            "B101",
            DateTime.Today);


        // ==============================
        // 7. RENEW TESTİ
        // ==============================

        Console.WriteLine(
            "\n--- RENEW TESTİ ---");

        // B101'in M101 tarafından iade edilmesiyle
        // tekrar 1 adet stok oluştu.
        libraryService.Borrow(
            "M103",
            "B101");

        Console.WriteLine(
            "1. uzatma denemesi:");

        libraryService.Renew(
            "M103",
            "B101");

        Console.WriteLine(
            "2. uzatma denemesi:");

        libraryService.Renew(
            "M103",
            "B101");


        // ==============================
        // 8. ÜYE LİSTESİ
        // ==============================

        libraryService.PrintMemberList();


        // ==============================
        // 9. KİTAP LİSTESİ
        // ==============================

        libraryService.PrintBookList();


        // ==============================
        // 10. İŞLEM GEÇMİŞİ
        // ==============================

        libraryService.PrintHistory("M101");


        // ==============================
        // 11. HATA YÖNETİMİ
        // ==============================

        Console.WriteLine(
            "\n--- HATA YÖNETİMİ ---");

        try
        {
            Console.WriteLine(
                "Var olmayan üyeyle işlem deneniyor:");

            libraryService.Borrow(
                "M999",
                "B101");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"YAKALANAN HATA: {ex.Message}");
        }


        // ==============================
        // PROGRAM SONU
        // ==============================

        Console.WriteLine(
            "\n=== UYGULAMA SONLANDI ===");
    }
}