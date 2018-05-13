﻿using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {


        [Test]
        public void testRegularItem()
        {
            var items = new List<Item> {new Item {Name = "meat", SellIn = 10, Quality = 25}};
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("meat", items[0].Name);
            Assert.AreEqual(24, items[0].Quality);
            Assert.AreEqual(9, items[0].SellIn);

        }

        [Test]
        public void testRegularOldItem()
        {
            var items = new List<Item> { new Item { Name = "meat", SellIn = 1, Quality = 25 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual("meat", items[0].Name);
            Assert.AreEqual(20, items[0].Quality);
            Assert.AreEqual(-2, items[0].SellIn);

        }

        [Test]
        public void testNegativeQuality()
        {
            var items = new List<Item> { new Item { Name = "meat", SellIn = 1, Quality = 1 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual("meat", items[0].Name);
            Assert.GreaterOrEqual(0, items[0].Quality);

        }

        [Test]
        public void testAgedBrie()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }

        [Test]
        public void testAgedBrieTooBigQuality()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 49 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }

        [Test]
        public void testSulfuras()
        {
            var items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 1, Quality = 80 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
        }

        [Test]
        public void testBackstagePass()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 13, Quality = 25 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(26, items[0].Quality);
        }

        [Test]
        public void testBackstagePassUnder10()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 8, Quality = 25 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(27, items[0].Quality);
        }

        [Test]
        public void testBackstagePassUnder5()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 4, Quality = 25 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(28, items[0].Quality);
        }

        [Test]
        public void testOldBackstage()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 0, Quality = 25 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }


    }
}
