using TradeGameNamespace.Inventory;
using TradeGameNamespace.Locations;
using TradeGameNamespace.RuntimeState;
using TradeGameNamespace.RuntimeState.States;
using TradeGameNamespace.Systems;
using TradeGameNamespace.Trader.So;
using UnityEngine;

namespace TradeGameNamespace.Player
{
    [CreateAssetMenu(fileName = "PlayerAbstractInitializerFactory", menuName = "Player/AbstractInitializerFactory")]
    public class SoPlayerAbstractInitializerSystem : ScriptableObject, ISystemFactory<IPlayerInitializerSystem>
    {
        [SerializeField]
        private InterfaceReference<ITraderFactory> playerTraderFactory;
        [SerializeField]
        private InterfaceReference<ILocationFactory> playerLocationFactory;
        
        private IRuntimeStateHandlerSystem _runtimeStateHandlerSystem;
        private IInventory _inventory;


        public IPlayerInitializerSystem Create() {
            return new PlayerInitializerSystem(playerTraderFactory.Value, playerLocationFactory.Value);
        }
    }
}