using System.Collections.Generic;

namespace TradeGameNamespace.Inventory
{
    public interface IInventory
    {
        int Capacity { get; }
        int ElementCount { get; }
        bool IsFull { get; }
        IReadOnlyList<IInventoryElement> GetElements { get; }
        bool ContainsElement(IInventoryElement element);
        void AddElement(IInventoryElement element);
        void RemoveElement(IInventoryElement element);
        
    }
}