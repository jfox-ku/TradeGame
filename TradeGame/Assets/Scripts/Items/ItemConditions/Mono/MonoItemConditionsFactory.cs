using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace TradeGameNamespace.Items.ItemConditions
{
    public class MonoItemConditionsFactory : MonoBehaviour, IItemConditionsFactory
    {
        [SerializeField]
        private List<InterfaceReference<IItemCondition>> itemConditions;

        private List<IItemCondition> InternalItemConditions =>
            itemConditions.ConvertAll<IItemCondition>(condition => condition.Value);

        public List<IItemCondition> Create() {
            return InternalItemConditions;
        }

        [Button]
        public void ReadItemConditions() {
            var monoBehaviours = gameObject.GetComponents<MonoBehaviour>();
            foreach (var factory in monoBehaviours) {
                if (factory is IItemConditionFactory<IItemCondition> itemConditionFactory) {
                    var itemCondition = itemConditionFactory.Create();
                    var reference = new InterfaceReference<IItemCondition>();
                    reference.Value = itemCondition;
                    itemConditions.Add(reference);
                }
            }

        }
    }
}