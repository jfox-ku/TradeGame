using System;
using System.Collections.Generic;

namespace TradeGameNamespace.Inventory
{
    [Serializable]
    public class Inventory : IInventory
    {
        public const int DEFAULT_CAPACITY = 10;
        
        public int Capacity { get; private set; }
        public int ElementCount => elements.Count;
        public bool IsFull => ElementCount >= Capacity;
        public IReadOnlyList<IInventoryElement> GetElements => elements.AsReadOnly();
        
        private readonly List<IInventoryElement> elements;

        public Inventory(List<IInventoryElement> elements, int capacity) {
                this.elements = elements;
                Capacity = capacity;
        }
        
        public Inventory(int capacity = DEFAULT_CAPACITY) {
            elements = new List<IInventoryElement>();
            Capacity = capacity;
        }
        
        public bool ContainsElement(IInventoryElement element) {
            return elements.Contains(element);
        }

        public void AddElement(IInventoryElement element) {
            if (ContainsElement(element)) {
                throw new System.ArgumentException("Element already in inventory", nameof(element));
            }

            if (IsFull) {
                throw new System.InvalidOperationException("Inventory is full");
            }
            elements.Add(element);
        }

        public void RemoveElement(IInventoryElement element) {
            if (!ContainsElement(element)) {
                throw new System.ArgumentException("Element not found in inventory", nameof(element));
            }
            elements.Remove(element);
        }
    }
}