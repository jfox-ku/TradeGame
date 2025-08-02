using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Inventory
{
    public class SavedInventoryFactory : IInventoryFactory
    {
        public string SaveName { get; }
        
        public SavedInventoryFactory(string saveName) {
            SaveName = saveName;
        }
        
        public IInventory CreateInventory() {
            FileManager.LoadFromFile(SaveName, out var json);
            var savedInventory = JsonUtility.FromJson<SavedInventory>(json);
            if (savedInventory != null) return savedInventory;
            Debug.LogWarning($"No saved inventory found for {SaveName}. Creating a new one.");
            return new SavedInventory(new List<IInventoryElement>(),Inventory.DEFAULT_CAPACITY, SaveName);

        }
    }
}