using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    public class SoItemConditionsFactory : ScriptableObject, IItemConditionsFactory
    {
        [SerializeField]
        private List<InterfaceReference<IItemCondition>> ItemConditions;
        
        public List<IItemCondition> CreateItemConditions() {
            var itemConditions = new List<IItemCondition>();
            foreach (var itemConditionReference in ItemConditions) {
                itemConditions.Add(itemConditionReference.Value);
            }
            return itemConditions;
        }
    }
}