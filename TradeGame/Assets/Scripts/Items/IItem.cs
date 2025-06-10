using TradeGameNamespace.Inventory;
using TradeGameNamespace.Items.ItemConditions;
using TradeGameNamespace.ValueSystem;

namespace TradeGameNamespace.Items
{
    public interface IItem : IValuable, IInventoryElement, IItemConditionHandler
    {
        IItemDefinition Definition { get; }
    }
}