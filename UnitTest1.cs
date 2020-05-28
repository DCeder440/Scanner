using System;
using Xunit;
using Scanner;

namespace ScannerTests
{
    public class UnitTest1
    {
        [Fact]
        public void AreLookupItemsPresent()
        {
            var shoppingCart = new ShoppingCart();
            Assert.True(shoppingCart.GetLookupItems().ContainsKey("A"));
            Assert.True(shoppingCart.GetLookupItems().ContainsKey("B"));
            Assert.True(shoppingCart.GetLookupItems().ContainsKey("C"));
            Assert.True(shoppingCart.GetLookupItems().ContainsKey("D"));
        }
        [Fact]
        public void MissingItemReturnsEmptyScannedItem()
        {
            var shoppingCart = new ShoppingCart();
            Assert.False(shoppingCart.ScanItem("X").Item.Length > 0);
        }
        [Fact]
        public void ExistingItemReturnsScannedItem()
        {
            var shoppingCart = new ShoppingCart();
            Assert.True(shoppingCart.ScanItem("A").Item.Length > 0);
        }
        [Fact]
        public void SingleItemATotalEqualsPrice()
        {
            var shoppingCart = new ShoppingCart();
            Assert.True(shoppingCart.ScanItem("A").Total == 5);
        }
        [Fact]
        public void MultipleItemATotalEqualsOffer()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            Assert.True(shoppingCart.ScanItem("A").Total == 13);
        }
        [Fact]
        public void MultiplePlusSingleItemATotalEqualsOfferPlusPrice()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            shoppingCart.ScanItem("A");
            Assert.True(shoppingCart.ScanItem("A").Total == 18);
        }
        [Fact]
        public void NonOfferItemEqualsitemCountTimesPrice()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.ScanItem("C");
            Assert.True(shoppingCart.ScanItem("C").Total == 4);
        }
    }
}
