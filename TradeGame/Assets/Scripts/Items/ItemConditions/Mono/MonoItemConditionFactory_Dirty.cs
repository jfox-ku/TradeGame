using NaughtyAttributes;
using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    [RequireComponent(typeof(MonoItemConditionsFactory))]
    public class MonoItemConditionFactory_Dirty : MonoItemConditionFactory<ItemCondition_Dirty>
    {
        [SerializeField, MinValue(-0), MaxValue(ItemCondition_Dirty.MAX_DIRTY_AMOUNT)]
        private float DirtyAmount = 0f;
        
        public override ItemCondition_Dirty CreateItemCondition() {
            return new ItemCondition_Dirty(DirtyAmount);
        }
    }
}