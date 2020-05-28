using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Scanner
{
    public class ShoppingCart
    {
        Dictionary<string, LookupItem> _lookupItems = new Dictionary<string, LookupItem>();
        Dictionary<string, ScannedItem> _scannedItems = new Dictionary<string, ScannedItem>();
        public ShoppingCart()
        {
            // Seed _lookupItems with data - normally this would come from a repository
            _lookupItems.Add("A", new LookupItem(5.0m, 3, 13.0m));
            _lookupItems.Add("B", new LookupItem(3.0m, 2, 4.50m));
            _lookupItems.Add("C", new LookupItem(2.0m, 1, 2.00m));
            _lookupItems.Add("D", new LookupItem(1.50m, 1, 1.50m));
        }

        public Dictionary<string, ScannedItem> GetScannedItems()
        {
            return _scannedItems;
        }

        public Dictionary<string, LookupItem> GetLookupItems()
        {
            return _lookupItems;
        }

        public ScannedItem ScanItem(string item)
        {
            if (_lookupItems.ContainsKey(item))
            {
                if (!_scannedItems.ContainsKey(item))
                {
                    _scannedItems.Add(item, new ScannedItem(item, 0, 0));
                }
                var lookupPrice = _lookupItems[item].Price;
                var lookupQuantity = _lookupItems[item].Quantity;
                var lookupOffer = _lookupItems[item].Offer;

                var scannedItem = new ScannedItem(item,0,0);
                var itemCount = _scannedItems[item].Quantity + 1;
                var multiples = itemCount / lookupQuantity;
                var remainder = itemCount % lookupQuantity;
                var total = (multiples * lookupOffer) + (remainder * lookupPrice);
                scannedItem.Quantity = itemCount;
                scannedItem.Total = total;
                _scannedItems[item] = scannedItem;
                return scannedItem;
            }
            return new ScannedItem(string.Empty, 0, 0);
        }

    }
}
