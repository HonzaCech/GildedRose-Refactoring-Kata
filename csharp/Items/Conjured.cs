using System;

namespace csharp
{
    public class Conjured : Item, IItem
    {
        public Conjured(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = Math.Min(quality, 50);
        }

        public void UpdateQuality()
        {
            SellIn--;
            Quality = SellIn < 0 ? Quality - 4 : Quality - 2;
            Quality = Math.Max(Quality, 0);
        }
    }
}