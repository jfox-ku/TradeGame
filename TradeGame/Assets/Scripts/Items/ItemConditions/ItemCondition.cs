using System;
using UnityEngine;

namespace TradeGameNamespace.Items.ItemConditions
{
    [Serializable]
    public abstract class ItemCondition : IItemCondition
    {
        [field: SerializeField]
        public string Name { get; }
        [field: SerializeField]
        protected virtual float ValuePercentDelta { get; }

        protected ItemCondition(string name, float valuePercentDelta = 0f) {
            Name = name;
            ValuePercentDelta = valuePercentDelta;
        }
        
        public float GetValueDelta(float value) {
            return value * ValuePercentDelta;
        }
    }
}