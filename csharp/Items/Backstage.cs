using System;

namespace csharp
{
    public class Backstage : Item, IItem
    {
        public Backstage(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = Math.Min(quality, 50);
        }

        public void UpdateQuality()
        {
            SellIn--;
            if (SellIn < 0)
            {
                Quality = 0;
            } 
            else if (SellIn <= 5)
            {
                Quality += 3;
            }
            else if (SellIn <= 10)
            {
                Quality += 2;
            }
            else
            {
                Quality++;
            }
            Quality = Math.Min(Quality, 50);
        }
    }
}