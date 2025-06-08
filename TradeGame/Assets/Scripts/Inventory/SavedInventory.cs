using System;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace TradeGameNamespace.Inventory
{
    [Serializable]
    public class SavedInventory : Inventory
    {
        private string _saveName;
        
        public SavedInventory(List<IInventoryElement> elements, int capacity, string saveName) : base(elements, capacity) {
            _saveName = saveName;
        }
        
        [Button]
        public void Save()
        {
            var json = JsonUtility.ToJson(this);
            FileManager.WriteToFile(_saveName, json);
        }
    }
}