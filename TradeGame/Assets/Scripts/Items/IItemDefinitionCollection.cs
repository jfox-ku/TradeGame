using System.Collections.Generic;

namespace TradeGameNamespace.Items
{
    public interface IItemDefinitionCollection
    {
        IEnumerable<IItemDefinition> GetItems();
    }
}