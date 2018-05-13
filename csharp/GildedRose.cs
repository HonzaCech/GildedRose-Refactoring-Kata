using System.Collections.Generic;
using ApprovalUtilities.Utilities;

namespace csharp
{
    public class GildedRose
    {
        IList<IItem> Items;
        public GildedRose(IList<IItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            Items.ForEach(item => item.UpdateQuality());
        }
    }
}
