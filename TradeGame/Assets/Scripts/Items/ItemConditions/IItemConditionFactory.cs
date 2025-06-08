namespace TradeGameNamespace.Items.ItemConditions
{
    public interface IItemConditionFactory<out T> where T : IItemCondition
    {
        public T CreateItemCondition();
    }
    
    
    
}