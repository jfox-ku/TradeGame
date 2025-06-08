using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    public class MonoItemConditionsFactory : MonoBehaviour, IItemConditionsFactory
    {
        [SerializeField]
        private List<InterfaceReference<IItemCondition>> itemConditions;

        private List<IItemCondition> InternalItemConditions =>
            itemConditions.ConvertAll<IItemCondition>(condition => condition.Value);

        public List<IItemCondition> CreateItemConditions() {
            return InternalItemConditions;
        }

        [Button]
        public void ReadItemConditions() {
            var monoBehaviours = gameObject.GetComponents<MonoBehaviour>();
            foreach (var factory in monoBehaviours) {
                if (factory is IItemConditionFactory<IItemCondition> itemConditionFactory) {
                    var itemCondition = itemConditionFactory.CreateItemCondition();
                    var reference = new InterfaceReference<IItemCondition>();
                    reference.Value = itemCondition;
                    itemConditions.Add(reference);
                }
            }

        }
    }
}