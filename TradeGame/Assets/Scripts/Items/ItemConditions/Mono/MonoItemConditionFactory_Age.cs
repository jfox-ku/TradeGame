using UnityEngine;

namespace TradeGameNamespace.Items.ItemConditions
{
    public class MonoItemConditionFactory_Age : MonoItemConditionFactory<ItemCondition_Age>
    {
        
        [SerializeField] private AnimationCurve AgeToValuePercentDeltaCurve;
        [SerializeField] private int Age = 0;
        
        public override ItemCondition_Age Create() {
            return new ItemCondition_Age(Age, AgeToValuePercentDelta);
        }

        private float AgeToValuePercentDelta(int arg) {
            return AgeToValuePercentDeltaCurve.Evaluate(arg);
        }
    }
}