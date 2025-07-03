using TradeGameNamespace.Items;
using TradeGameNamespace.Random;
using TradeGameNamespace.Trader;
using UnityEngine;

namespace TradeGameNamespace.Inventory
{
    [CreateAssetMenu(fileName = "New InventoryFactoryTraderParameter", menuName = "Factories/Inventory/TraderParameter")]
    public class SoInventoryAbstractFactoryTraderParameter : ScriptableObject, IParameterizedFactory<ITrader, IInventory>
    {
        [SerializeField]
        private InterfaceReference<IParameterizedFactory<ITrader, IItem>> _itemFactoryTraderParameter;

        [SerializeField]
        protected InterfaceReference<IRandomFactory> RandomFactory;
        [SerializeField]
        private Vector2Int ItemCountRange = new Vector2Int(1, 8);
        
        private IRandom _random;
        
        protected IRandom Random => _random ??= RandomFactory.Value.Create();
        
        public IInventory CreateInventoryForTrader(ITrader trader) {
            var elementCount = Random.NextInt(ItemCountRange.x, ItemCountRange.y + 1);
            var inventory = new Inventory();
            
            for (var i = 0; i < elementCount; i++) {
                var item = _itemFactoryTraderParameter.Value.CreateInventoryForTrader(trader);
                inventory.AddElement(item);
            }
            
            return inventory;
        }
    }
}