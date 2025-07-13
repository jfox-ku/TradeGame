using System;
using TradeGameNamespace.Inventory;

namespace TradeGameNamespace.RuntimeState.States
{
    public class PlayerInventoryState : IRuntimeState
    {
        public event Action<IRuntimeState> OnStateChanged;
        public RuntimeStateID StateID => RuntimeStateID.PlayerInventoryState;
        public IInventory PlayerInventory => _inventory;
        
        private IInventory _inventory;
        
        public PlayerInventoryState(IInventory inventory) {
            _inventory = inventory;
            _inventory.OnInventoryChanged += PublishStateChange;
        }
        
        private void PublishStateChange(IInventory inventory)
        {
            OnStateChanged?.Invoke(this);
        }
    }
}