using UnityEngine;

namespace DefaultNamespace.Items.ItemConditions
{
    public class MonoItemConditionFactory_Age : MonoItemConditionFactory<ItemCondition_Age>
    {
        
        [SerializeField] private AnimationCurve AgeToValuePercentDeltaCurve;
        [SerializeField] private int Age = 0;
        
        public override ItemCondition_Age CreateItemCondition() {
            return new ItemCondition_Age(Age, AgeToValuePercentDelta);
        }

        private float AgeToValuePercentDelta(int arg) {
            return AgeToValuePercentDeltaCurve.Evaluate(arg);
        }
    }
}