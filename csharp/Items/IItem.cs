namespace csharp
{
    public interface IItem
    {
        void UpdateQuality();

        string Name { get; set; }
        int SellIn { get; set; }
        int Quality { get; set; }
    }
}