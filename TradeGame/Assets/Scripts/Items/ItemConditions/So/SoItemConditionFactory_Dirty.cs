using TradeGameNamespace.Items.ItemConditions;
using TradeGameNamespace.Random;
using UnityEngine;

namespace Items.ItemConditions.So
{
    [CreateAssetMenu(fileName = "SoItemConditionFactory_Dirty", menuName = "ItemConditions/Factories/Dirty")]
    public class SoItemConditionFactory_Dirty : SoItemConditionFactory<ItemCondition_Dirty>
    {
        [SerializeField]
        private InterfaceReference<IRandom> RandomGenerator;
        
        public override ItemCondition_Dirty Create() {
            return new ItemCondition_Dirty(RandomGenerator.Value.Next() * ItemCondition_Dirty.MAX_DIRTY_AMOUNT);
        }
    }
}