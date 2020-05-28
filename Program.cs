using System;
using System.Collections.Generic;

namespace Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.ScanItem("D");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("D");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("B");
            shoppingCart.ScanItem("C");
            shoppingCart.ScanItem("C");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            foreach (KeyValuePair<string, ScannedItem> entry in shoppingCart.GetScannedItems())
            {
                Console.WriteLine(string.Format("Item: {0}, Quantity: {1}, Total: {2}", entry.Value.Item, entry.Value.Quantity, entry.Value.Total));
            }
            Console.ReadKey();
        }
    }
}

