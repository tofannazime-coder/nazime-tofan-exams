using System;

namespace Odev03_ShoppingCart.Models {
    public class ShoppingCart
    {
        public int ItemCount { get; set; }
        public decimal TotalPrice { get; set; }
     
      public void AddItem(decimal price)
    {
        ItemCount++;
        TotalPrice += price; 
        Console.WriteLine("Sepet Güncellendi: Ürün Adedi: " + ItemCount + ", Toplam Fiyat: " + TotalPrice);
    }
    public void ClearCart()
    {
        ItemCount = 0;
        TotalPrice = 0;
        Console.WriteLine("Sepetteki ürünler silindi, Sepet boş.");
    }
}
}
   
