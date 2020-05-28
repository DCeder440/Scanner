using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner
{
    public struct ScannedItem
    {
        public string Item;
        public int Quantity;
        public decimal Total;
        
        public ScannedItem(string item, int quantity, decimal total)
        {
            Item = item;
            Quantity = quantity;
            Total = total;
        }
    }
}
