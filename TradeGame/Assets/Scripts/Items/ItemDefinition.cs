using System;
using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;

namespace TradeGameNamespace.Items
{
    public class ItemDefinition : IItemDefinition, IComparable<IItemDefinition>
    {
        public string Name { get; }
        public float BaseValue { get; }
        public float Weight { get; }
        public string Description { get; }
        public List<IItemCategory> Categories { get; }

        public ItemDefinition() {
            Name = "Default Item";
            BaseValue = 0.0f;
            Weight = 0.0f;
            Description = "This is a default item description.";
            Categories = new List<IItemCategory>();
        }
        
        public ItemDefinition(string name, float baseValue, float weight, string description, List<IItemCategory> categories) {
            Name = name;
            BaseValue = baseValue;
            Weight = weight;
            Description = description;
            Categories = categories;
        }

        public int CompareTo(IItemDefinition other) {
            return String.CompareOrdinal(Name, other.Name);
        }

        public override bool Equals(object obj) {
            if (obj is IItemDefinition otherItemDefinition) {
                return CompareTo(otherItemDefinition) == 0;
            }
            
            return base.Equals(obj);
        }
    }
}