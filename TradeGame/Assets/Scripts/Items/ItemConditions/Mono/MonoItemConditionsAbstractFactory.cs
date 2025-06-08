using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    public class MonoItemConditionsAbstractFactory : MonoBehaviour, IItemConditionsFactory
    {
        [SerializeField]
        public List<InterfaceReference<IItemConditionFactory<IItemCondition>>> ItemConditionFactory = new();
        
        public List<IItemCondition> CreateItemConditions() {
            var list = new List<IItemCondition>();
            foreach (var factoryInterfaceReference in ItemConditionFactory) {
                var condition = factoryInterfaceReference.Value.CreateItemCondition();
                if (condition != null) {
                    list.Add(condition);
                }
            }

            return list;
        }
    }
}