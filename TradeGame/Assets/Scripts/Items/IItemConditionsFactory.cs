using System.Collections.Generic;
using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Items
{
    public interface IItemConditionsFactory
    {
        List<IItemCondition> CreateItemConditions();
    }
}