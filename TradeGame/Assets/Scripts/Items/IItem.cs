using DefaultNamespace.Inventory;
using DefaultNamespace.Items.ItemConditions;
using DefaultNamespace.ValueSystem;

namespace DefaultNamespace.Items
{
    public interface IItem : IValuable, IInventoryElement, IItemConditionHandler
    {
        IItemData Data { get; }
    }
}