using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace csharp
{
    public class RegularItem : Item, IItem
    {
        public RegularItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = Math.Min(quality, 50);
        }

        public void UpdateQuality()
        {
            SellIn--;
            Quality = SellIn < 0 ? Quality - 2 : Quality - 1;
            Quality = Math.Max(Quality, 0);
        }
    }
}