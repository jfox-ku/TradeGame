using System.Collections.Generic;
using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Items
{
    public interface IItemConditionsFactory : IFactory<List<IItemCondition>>
    {
        
    }
}