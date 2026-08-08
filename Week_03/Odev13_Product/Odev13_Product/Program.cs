using System;
using Odev13_Product.Models;

namespace Odev13_Product;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
              ProductCode = 37849,
              Name = "Smart Watch",
              Category = "Electronics",
              UnitPrice = 9000.00m

            },
             new Product
            {
              ProductCode = 85397,
              Name = "Camera ",
              Category = "Electronics",
              UnitPrice = 1050.00m

            },
             new Product
            {
              ProductCode = 49598,
              Name = "Keyboard",
              Category = "Electronics",
              UnitPrice = 4550.00m

            },
             new Product
            {
              ProductCode = 30895,
              Name = "Monitor",
              Category = "Electronics",
              UnitPrice = 5000.00m

            }
        };
        foreach (var product in products)
        {
            if(product.Category== "Electronics")
            {
                Console.WriteLine($" Product Code: {product.ProductCode}");
                Console.WriteLine($" Name: {product.Name}");
                Console.WriteLine($" Category: {product.Category}");
                Console.WriteLine($" Unit Price: {product.UnitPrice}");
                Console.WriteLine();

            }
        }
    }
}