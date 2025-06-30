using System;
using UnityEngine;

namespace TradeGameNamespace.Items.ItemConditions
{
    [Serializable]
    public abstract class ItemCondition : IItemCondition
    {
        public string Name { get; }
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