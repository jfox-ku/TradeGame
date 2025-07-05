using UnityEngine;

namespace TradeGameNamespace.Inventory
{
    [CreateAssetMenu(fileName = "SavedInventoryFactory", menuName = "Systems/Inventory/SavedInventoryFactory")]
    public class SoSavedInventoryFactory : ScriptableObject, IInventoryFactory
    {
        [SerializeField]
        private string SaveName;
        
        SavedInventoryFactory _internalFactory;
        
        public IInventory CreateInventory() {
            _internalFactory = new SavedInventoryFactory(SaveName);
            var inventory = _internalFactory.CreateInventory();
            return inventory;
        }
    }
}