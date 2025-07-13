using TradeGameNamespace.Inventory;
using TradeGameNamespace.Locations;
using TradeGameNamespace.RuntimeState;
using TradeGameNamespace.RuntimeState.States;
using TradeGameNamespace.Systems;
using TradeGameNamespace.Trader.So;

namespace TradeGameNamespace.Player
{
    public class PlayerInitializerSystem : IPlayerInitializerSystem
    {
        private readonly ITraderFactory playerTraderFactory;
        private readonly ILocationFactory playerLocationFactory;
        
        public PlayerInitializerSystem(ITraderFactory playerTraderFactory, ILocationFactory playerLocationFactory) {
            this.playerTraderFactory = playerTraderFactory;
            this.playerLocationFactory = playerLocationFactory;
        }
        
        private IRuntimeStateHandlerSystem _runtimeStateHandlerSystem;
        private IInventory _inventory;
        
        public void Initialize(ISystemHandler systemHandler) {
            _runtimeStateHandlerSystem = systemHandler.GetSystem<IRuntimeStateHandlerSystem>();
            
            var playerTrader = playerTraderFactory.Create();
            var playerLocation = playerLocationFactory.Create();
            
            _inventory = playerTrader.Inventory;

            var playerInventoryState = new PlayerInventoryState(_inventory);
            var playerInventoryValueState = new PlayerInventoryValueState(_inventory);
            var playerLocationRuntimeState = new PlayerLocationState(playerLocation);
            
            _runtimeStateHandlerSystem.AddRuntimeState(playerInventoryState);
            _runtimeStateHandlerSystem.AddRuntimeState(playerInventoryValueState);
            _runtimeStateHandlerSystem.AddRuntimeState(playerLocationRuntimeState);
            
        }
    }
}