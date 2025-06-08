using DefaultNamespace.Inventory;
using UnityEngine;

namespace DefaultNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "TraderFactory", menuName = "ScriptableObjects/Trader/Factory")]
    public class SoTraderFactory : ScriptableObject, ITraderFactory
    {
        [SerializeField]
        private InterfaceReference<IInventory> _inventoryReference;
        [SerializeField]
        private InterfaceReference<ITraderData> _traderData;
        
        public ITrader Create() {
            return new Trader(_inventoryReference.Value, _traderData.Value);
        }
    }
}