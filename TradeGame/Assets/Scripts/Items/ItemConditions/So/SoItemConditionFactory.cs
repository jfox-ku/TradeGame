using TradeGameNamespace.Items.ItemConditions;
using UnityEngine;

namespace Items.ItemConditions.So
{
    public abstract class SoItemConditionFactory<T> : ScriptableObject, IItemConditionFactory<T> where T : IItemCondition
    {
        public abstract T Create();
    }
}