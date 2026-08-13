using System;

namespace _01_MiniBankApp.scr.Interfaces;
public interface IRepository<T> //Generic yapıda kullandık.Çünkü sisteme farklı sınıflar eklenebilir.
{
    void Add(T item); //T tipinde bir item eklenecek.
    T? GetById(Guid id); //Kimliğe göre veri getirecek bize müşterinin benzersiz kimliği ile hesabını getirecek.
    List<T> GetAll(); //Sistemdeki tüm hesapları döndürür.
    void Delete(Guid id); //T tipinde bir item silecek.


}
