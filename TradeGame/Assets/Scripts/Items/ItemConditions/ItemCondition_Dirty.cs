

using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    public class ItemCondition_Dirty : ItemCondition
    {
        public const float MAX_DIRTY_AMOUNT = 100f;
        
        private float _currentDirtyAmount;
        
        private float dirtyPercentNormalized => Mathf.Clamp(_currentDirtyAmount, -MAX_DIRTY_AMOUNT, MAX_DIRTY_AMOUNT) / MAX_DIRTY_AMOUNT;


        protected override float ValuePercentDelta => -dirtyPercentNormalized;

        public ItemCondition_Dirty(float currentDirtyAmount) : base("Dirty") {
            _currentDirtyAmount = currentDirtyAmount;
        }
        
        
        
        
    }
}