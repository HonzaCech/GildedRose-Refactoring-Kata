using NUnit.Framework;
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
            Assert.AreEqual(items[0].Name, "meat");
            Assert.AreEqual(items[0].Quality, 24);
            Assert.AreEqual(items[0].SellIn, 9);

        }


    }
}
