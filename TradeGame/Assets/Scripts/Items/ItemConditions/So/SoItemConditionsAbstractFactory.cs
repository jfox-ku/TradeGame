using System.Collections.Generic;
using TradeGameNamespace.Items.ItemConditions;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "SoItemConditionsAbstractFactory", menuName = "ScriptableObjects/ItemConditions/SoItemConditionsAbstractFactory")]
    public class SoItemConditionsAbstractFactory : ScriptableObject, IItemConditionsFactory
    {
        [SerializeField]
        private List<InterfaceReference<IItemConditionFactory<IItemCondition>>> itemConditionFactories;
        
        public List<IItemCondition> CreateItemConditions() {
            var conditions = new List<IItemCondition>();
            foreach (var factoryReference in itemConditionFactories) {
                var condition = factoryReference.Value.CreateItemCondition();
                conditions.Add(condition);
            }
            return conditions;
        }
    }
}