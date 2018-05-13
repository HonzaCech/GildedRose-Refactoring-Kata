using System;

namespace csharp
{
    public class AgedBrie : Item, IItem
    {

        public AgedBrie(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = Math.Min(quality, 50);
        }

        public void UpdateQuality()
        {
            Quality = Math.Min(50, Quality + 1);
            SellIn--;
        }
    }
}