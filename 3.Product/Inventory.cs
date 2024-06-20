using System;
using System.Collections.Generic;

namespace InventoryExample
{
    class Inventory
    {
        public Dictionary<string, int> Products { get; } = new Dictionary<string, int>();

        public void AddProduct(string productName, int quantity)
        {
            if (!Products.ContainsKey(productName))
                Products[productName] = 0;

            Products[productName] += quantity;
        }

        public void RemoveProduct(string productName)
        {
            if (Products.ContainsKey(productName))
                Products.Remove(productName);
        }

        public void UpdateQuantity(string productName, int newQuantity)
        {
            if (Products.ContainsKey(productName))
                Products[productName] = newQuantity;
        }

        public int GetQuantityByProduct(string productName)
        {
            if (Products.ContainsKey(productName))
                return Products[productName];
            else
                return 0; // Məhsul tapılmadı
        }
    }
}