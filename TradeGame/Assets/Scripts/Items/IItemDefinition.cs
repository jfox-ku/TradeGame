using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;

namespace TradeGameNamespace.Items
{
    public interface IItemDefinition
    {
        string Name { get; }
        public float BaseValue { get; }
        public float Weight { get; }
        public string Description { get; }
        public IReadOnlyList<IItemCategory> Categories { get; }
        public bool HasCategory(IItemCategory category);
        public IItemConditionsFactory ConditionsFactory { get; }
        
        public static IItemDefinition Default => new ItemDefinition();
    }
}