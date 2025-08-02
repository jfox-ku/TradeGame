using System;
using System.Collections.Generic;
using NaughtyAttributes;
using TradeGameNamespace.Items;
using TradeGameNamespace.Items.ItemConditions;
using TradeGameNamespace.Random;
using UnityEngine;

namespace Items.ItemConditions.So
{
    [CreateAssetMenu(fileName = "SoItemConditionsAbstractFactory_Random", menuName = "ItemConditions/SoItemConditionsAbstractFactory_Random")]
    public class SoItemConditionsAbstractFactory_Random : ScriptableObject, IItemConditionsFactory
    {
        [SerializeField]
        private List<ItemConditionFactoryReference> itemConditionFactories;
        [SerializeField]
        private InterfaceReference<IRandom> randomGenerator;
        
        public List<IItemCondition> Create() {
            var conditions = new List<IItemCondition>();
            foreach (var itemConditionFactoryReference in itemConditionFactories) {
                var randomNormalized = randomGenerator.Value.Next();
                if (itemConditionFactoryReference.ShouldCreate(randomNormalized)) {
                    var condition = itemConditionFactoryReference.factory.Value.Create();
                    conditions.Add(condition);
                }
            }
            return conditions;
        }
        
        [Serializable]
        private class ItemConditionFactoryReference
        {
            [Min(0f), MaxValue(1f)]
            public float normalizedChance;
            public InterfaceReference<IItemConditionFactory<IItemCondition>> factory;
            public bool ShouldCreate(float randomNormalized) => randomNormalized <= normalizedChance;
        }
        
    }
    
    
}