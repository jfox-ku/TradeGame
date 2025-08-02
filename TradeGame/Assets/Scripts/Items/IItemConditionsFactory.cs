using System.Collections.Generic;
using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Items
{
    public interface IItemConditionsFactory : IFactory<List<IItemCondition>>
    {
        public static IItemConditionsFactory Default => new DefaultItemConditionsFactory();
    }
    
    public class DefaultItemConditionsFactory : IItemConditionsFactory
    {
        public List<IItemCondition> Create()
        {
            return new List<IItemCondition>();
        }
    }
}