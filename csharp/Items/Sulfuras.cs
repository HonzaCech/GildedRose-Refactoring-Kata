namespace csharp
{
    public class Sulfuras : Item, IItem
    {

        public Sulfuras(string name, int sellIn, int quality = 80)
        {
            Name = name;
            SellIn = sellIn;
            Quality = 80;
        }

        public void UpdateQuality()
        {}
    }
}