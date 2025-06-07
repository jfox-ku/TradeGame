using System;

namespace DefaultNamespace.Items.ItemConditions
{
    public class ItemCondition_Age : ItemCondition
    {
        public int Age { get; set; }
        private readonly Func<int,float> ageToValuePercentDelta;
        protected override float ValuePercentDelta => ageToValuePercentDelta(Age);
        
        public ItemCondition_Age(int age, Func<int,float> ageToValuePercentDelta) : base("Age", 0f) {
            Age = age;
            this.ageToValuePercentDelta = ageToValuePercentDelta;
        }

    }
}