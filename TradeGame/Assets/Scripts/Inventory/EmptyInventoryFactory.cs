using System.Collections.Generic;

namespace DefaultNamespace.Inventory
{
    public class EmptyInventoryFactory : IInventoryFactory
    {
        public int BaseCapacity { get; set; } = 10;
        
        public IInventory CreateInventory() {
            return new Inventory(new List<IInventoryElement>(), BaseCapacity);
        }
        
        public IInventory CreateInventoryOfCapacity(int capacity) {
            return new Inventory(new List<IInventoryElement>(), capacity);
        }
    }
}