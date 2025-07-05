using TradeGameNamespace.Inventory;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "TraderAbstractFactory", menuName = "ScriptableObjects/Trader/AbstractFactory")]
    public class SoTraderAbstractFactory : ScriptableObject, ITraderFactory
    {
        [SerializeField]
        private InterfaceReference<IInventoryFactory> _inventoryFactoryReference;
        [SerializeField]
        private InterfaceReference<ITraderDataFactory> _traderDataFactoryReference;
        
        
        public ITrader Create() {
            var inventory = _inventoryFactoryReference.Value.CreateInventory();
            var traderData = _traderDataFactoryReference.Value.Create();
            return new Trader(inventory, traderData);
        }
    }
}