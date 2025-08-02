using TradeGameNamespace.Items.ItemConditions;
using TradeGameNamespace.Random;
using UnityEngine;

namespace Items.ItemConditions.So
{
    [CreateAssetMenu(fileName = "SoItemConditionFactory_Age", menuName = "ItemConditions/Factories/Age")]
    public class SoItemConditionFactory_Age : SoItemConditionFactory<ItemCondition_Age>
    {
        public AnimationCurve AgeToValuePercentDeltaCurve;
        public Vector2Int AgeRange = new Vector2Int(0, 100);
        public InterfaceReference<IRandom> RandomGenerator;
        
        public override ItemCondition_Age Create() {
            return new ItemCondition_Age(RandomGenerator.Value.NextInt(AgeRange.x, AgeRange.y), GetValuePercentDelta);
        }

        public float GetValuePercentDelta(int age) {
            var normalizedAge = (age - AgeRange.x) / (float) (AgeRange.y - AgeRange.x);
            return AgeToValuePercentDeltaCurve.Evaluate(normalizedAge);
        }
    }
}