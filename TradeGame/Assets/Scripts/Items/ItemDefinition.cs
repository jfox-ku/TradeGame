using System;
using System.Collections.Generic;
using System.Linq;
using TradeGameNamespace.Items.ItemCategories;

namespace TradeGameNamespace.Items
{
    public class ItemDefinition : IItemDefinition, IComparable<IItemDefinition>
    {
        public string Name { get; }
        public float BaseValue { get; }
        public float Weight { get; }
        public string Description { get; }
        public IReadOnlyList<IItemCategory> Categories { get; }
        public IItemConditionsFactory ConditionsFactory { get; }

        public ItemDefinition() {
            Name = "Default Item";
            BaseValue = 1.0f;
            Weight = 1.0f;
            Description = "This is a default item description.";
            Categories = new List<IItemCategory>();
            ConditionsFactory = IItemConditionsFactory.Default;
        }
        
        public ItemDefinition(string name, float baseValue = 1f, float weight = 1f, string description = "", List<IItemCategory> categories = null, IItemConditionsFactory conditionsFactory = null) {
            Name = name;
            BaseValue = baseValue;
            Weight = weight;
            Description = description;
            Categories = categories;
            ConditionsFactory = conditionsFactory ?? IItemConditionsFactory.Default;
        }
        
        public bool HasCategory(IItemCategory category) {
            return Categories.Contains(category);
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