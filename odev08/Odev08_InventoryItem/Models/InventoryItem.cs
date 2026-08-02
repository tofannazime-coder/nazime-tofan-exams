using System;

namespace Odev08_InventoryManagement.Models
{
    public class InventoryItem
    {
        public String ProductName { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }
        public void IncreaseStock(int amount)
        {
            Quantity += amount;
        }

        public bool DecreaseStock(int amount)
        {
            if (Quantity >= amount)
            {
                Quantity -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}