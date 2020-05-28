using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner
{
    public struct LookupItem
    {
        public decimal Price;
        public int Quantity;
        public decimal Offer;
        public LookupItem(decimal price, int quantity, decimal offer)
        {
            Price = price;
            Quantity = quantity;
            Offer = offer;
        }
    
    }
}
