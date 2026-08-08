using System;

namespace Odev03_ShoppingCart.Models;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(500.00m);
        cart.AddItem(250.00m);
        cart.AddItem(100.00m);
        cart.ClearCart();

    }
}
