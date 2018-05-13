namespace csharp
{
    public class RegularItem : Item
    {
        public void DecreaseQuality()
        {
            SellIn--;
            Quality = SellIn < 0 ? Quality - 2 : Quality - 1;
        }
    }
}