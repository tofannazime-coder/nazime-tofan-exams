# YANSITMA

➕ 1. Encapsulation
Encapsulation'ı Member ve Book sınıflarında kullandım.
Member sınıfında ödünç alınan kitap listesini private tuttum.
BorrowedCount ve BorrowedBooks özellikleri üzerinden kontrollü erişim sağladım.
Book sınıfında AvailableCopies alanını private set yaptım.
Stok değişikliklerini BorrowOne ve ReturnOne metotları üzerinden gerçekleştirdim.

➕ 2. Polymorphism
Polymorphism'i Member sınıfında kullandım.
Member abstract bir sınıf olarak tanımlandı.
StudentMember, AcademicMember ve GuestMember sınıfları
MaxBooks, LoanPeriodDays, CalculateLateFee ve GetMemberType
metotlarını kendi kurallarına göre override etti.
LibraryService üye tipini kontrol etmek yerine Member üzerinden çalıştı.

➕ 3. Interface kullanımı
IRepository<T> ve ILoanLogger interface'lerini kullandım.
Bu sayede LibraryService doğrudan somut repository veya logger
sınıflarına bağlı olmadı.
Farklı repository veya logger sınıfları gerektiğinde LibraryService'i
değiştirmeden yeni implementasyonlar eklenebilir.

➕  4. GuestMember eklenmesi
GuestMember eklerken sadece yeni bir Member sınıfı oluşturdum.
LibraryService üzerinde değişiklik yapmadım.
Bunun nedeni LibraryService'in StudentMember veya AcademicMember
gibi belirli sınıflara değil, abstract Member sınıfına bağlı olmasıdır.
Bu sayede yeni üye tipi çekirdek kod bozulmadan sisteme eklenebildi.