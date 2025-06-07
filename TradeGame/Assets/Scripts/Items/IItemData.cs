using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;

namespace DefaultNamespace.Items
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