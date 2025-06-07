using System.Collections.Generic;
using DefaultNamespace.Items.ItemConditions;

namespace DefaultNamespace.Items
{
    public interface IItemConditionsFactory
    {
        List<IItemCondition> CreateItemConditions();
    }
}