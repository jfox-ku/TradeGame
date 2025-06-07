namespace DefaultNamespace.Items.ItemConditions
{
    public interface IItemConditionFactory<out T> where T : IItemCondition
    {
        public T CreateItemCondition();
    }
    
    
    
}