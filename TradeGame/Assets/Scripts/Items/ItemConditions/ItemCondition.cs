namespace DefaultNamespace.Items.ItemConditions
{
    public abstract class ItemCondition : IItemCondition
    {
        public string Name { get; }
        protected virtual float ValuePercentDelta { get; }

        protected ItemCondition(string name, float valuePercentDelta = 0f)
        {
            Name = name;
            ValuePercentDelta = valuePercentDelta;
        }
        
        public virtual float GetValueDelta(float value) {
            return value * ValuePercentDelta;
        }

       
    }
}