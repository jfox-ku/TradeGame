using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;

namespace DefaultNamespace.Items
{
    public class ItemData : IItemData
    {
        public string Name { get; }
        public float BaseValue { get; }
        public float Weight { get; }
        public string Description { get; }
        public List<IItemCategory> Categories { get; }

        public ItemData() {
            Name = "Default Item";
            BaseValue = 0.0f;
            Weight = 0.0f;
            Description = "This is a default item description.";
            Categories = new List<IItemCategory>();
        }
        
        public ItemData(string name, float baseValue, float weight, string description, List<IItemCategory> categories) {
            Name = name;
            BaseValue = baseValue;
            Weight = weight;
            Description = description;
            Categories = categories;
        }
    }
}