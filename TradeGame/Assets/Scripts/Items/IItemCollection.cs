using System.Collections.Generic;

namespace TradeGameNamespace.Items
{
    public interface IItemCollection : IReadOnlyList<IItem>
    {
        static IItemCollection Default => new ItemCollection(new List<IItem>());
    }
}