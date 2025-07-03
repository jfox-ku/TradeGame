using TradeGameNamespace.Items;
using TradeGameNamespace.Locations;
using TradeGameNamespace.Random;
using UnityEngine;

namespace TradeGameNamespace.Inventory
{
    [CreateAssetMenu(fileName = "TraderInventoryFactory", menuName = "Inventory/TraderInventoryAbstractFactory")]
    public class SoTraderInventoryAbstractFactory : ScriptableObject, IInventoryFactory
    {
        [SerializeField]
        protected InterfaceReference<IItemFactory> ItemFactory;
        [SerializeField]
        protected InterfaceReference<IRandomFactory> RandomFactory;
        [SerializeField]
        private Vector2Int ItemCountRange = new Vector2Int(1, 8);
        
        private IRandom _random;
        protected IRandom Random => _random ??= RandomFactory.Value.Create();
        
        public IInventory CreateInventory() {
            var elementCount = Random.NextInt(ItemCountRange.x, ItemCountRange.y + 1);
            var inventory = new Inventory();
            
            
            for (var i = 0; i < elementCount; i++) {
                var item = CreateItem();
                inventory.AddElement(item);
            }
            
            return inventory;
        }

        protected virtual IItem CreateItem() {
            return ItemFactory.Value.CreateItem();
        }
    }
}