# YANSITMA

➕ 1. Encapsulation
Encapsulation'ı Account sınıfında kullandım.
Bakiye dışarıdan doğrudan değiştirilemeyecek şekilde korunmaktadır.
Para yatırma ve çekme işlemleri Deposit ve Withdraw metodları üzerinden yapılmaktadır.
Böylece hesap bakiyesinin negatif olması gibi hatalı durumlar kontrol edilmektedir.

➕ 2. Polymorphism
Polymorphism'i Account sınıfı ve ondan türeyen CheckingAccount,
SavingsAccount ve PremiumAccount sınıflarında kullandım.
Her hesap türü CanWithdraw, CalculateInterest ve GetAccountType
metodlarını kendi kurallarına göre uygulamaktadır.
BankService içerisinde hesap türünü kontrol eden if/else zinciri kullanılmamıştır.

➕ 3. Interface
IRepository ve ITransactionLogger interface'lerini kullandım.
Bu sayede BankService doğrudan somut repository veya logger sınıflarına bağlı değildir.
Farklı repository ve logger implementasyonları gerektiğinde
BankService değiştirilmeden kullanılabilir.

➕ 4. PremiumAccount
PremiumAccount sınıfını mevcut hesap yapısını bozmadan ekledim.
PremiumAccount, CheckingAccount sınıfından türetilmiştir ve
daha yüksek günlük çekim limiti ile farklı faiz oranına sahiptir.
PremiumAccount eklerken BankService dosyasına dokunmadım.
Yeni hesap türü sadece Program.cs üzerinden oluşturularak kullanılabildi.