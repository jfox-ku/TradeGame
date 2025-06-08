using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;

namespace TradeGameNamespace.Items
{
    public interface IItemData
    {
        string Name { get; }
        public float BaseValue { get; }
        public float Weight { get; }
        public string Description { get; }
        public List<IItemCategory> Categories { get; }
    }
}