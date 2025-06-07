using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    public abstract class MonoItemConditionFactory<T> : MonoBehaviour, IItemConditionFactory<T> where T : IItemCondition
    {
        public abstract T CreateItemCondition();
    }
}