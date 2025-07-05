using System;
using TradeGameNamespace.Inventory;
using TradeGameNamespace.ValueSystem;

namespace TradeGameNamespace.RuntimeState.States
{
    public class PlayerInventoryValueState : IRuntimeState
    {
        public event Action<IRuntimeState> OnStateChanged;
        public RuntimeStateID StateID => RuntimeStateID.PlayerInventoryValue;

        private IInventory _inventory;
        
        public float TotalBaseValue { get; private set; }
        
        public PlayerInventoryValueState(IInventory inventory) {
            _inventory = inventory;
            _inventory.OnInventoryChanged += RecalculateInventoryValue;
        }
        
        private void RecalculateInventoryValue(IInventory inventory) {
            TotalBaseValue = 0f;
            foreach (var element in _inventory.GetElements) {
                var valuableElement = (IValuable) element;
                if (valuableElement == null) continue;
                TotalBaseValue += valuableElement.Value;
            }
        }
    }
}