namespace TradeGameNamespace.Items.ItemConditions
{
    public interface IItemConditionFactory<out T> : IFactory<T> where T : IItemCondition
    {
       
    }
    
    
    
}