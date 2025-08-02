using System;
using System.Collections.Generic;
using System.Linq;
using TradeGameNamespace.Items.ItemCategories;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "ItemDefinition", menuName = "Items/ItemDefinition", order = 0)]
    public class SoItemDefinition : ScriptableObject, IItemDefinition, IComparable<IItemDefinition>
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private float _baseValue;
        [SerializeField]
        private float _weight;
        [SerializeField]
        private string _description;
        [SerializeField]
        private List<InterfaceReference<IItemCategory>> _categories;
        [SerializeField]
        private InterfaceReference<IItemConditionsFactory> _conditionsFactory;

        public string Name => _name;
        public float BaseValue => _baseValue;
        public float Weight => _weight;
        public string Description => _description;
        public IReadOnlyList<IItemCategory> Categories => _categories.ConvertAll(category => category.Value);
        
        public bool HasCategory(IItemCategory category) {
            return Categories.Contains(category);
        }

        public IItemConditionsFactory ConditionsFactory => _conditionsFactory.Value;

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