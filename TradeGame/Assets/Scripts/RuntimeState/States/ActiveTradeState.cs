using System;
using System.Collections.Generic;
using TradeGameNamespace.Items;
using TradeGameNamespace.Trader;

namespace TradeGameNamespace.RuntimeState.States
{
    public class ActiveTradeState : IRuntimeState
    {
        public event Action<IRuntimeState> OnStateChanged;
        public RuntimeStateID StateID => RuntimeStateID.ActiveTrade;
        
        public ITrader PlayerTrader { get; private set; }
        public ITrader Trader { get; private set; }
        
        public List<IItem> OfferedItems { get; private set; }
        public List<IItem> RequestedItems { get; private set; }
        
        public ActiveTradeState(ITrader playerTrader, ITrader trader, List<IItem> offeredItems, List<IItem> requestedItems)
        {
            PlayerTrader = playerTrader;
            Trader = trader;
            OfferedItems = offeredItems;
            RequestedItems = requestedItems;
        }
        
        public void AddOfferedItem(IItem item)
        {
            if (OfferedItems.Contains(item)) {
                throw new Exception($"Item {item.Definition.Name} is already offered");
            }
            OfferedItems.Add(item);
            OnStateChanged?.Invoke(this);
        }
        
        public void RemoveOfferedItem(IItem item)
        {
            if (!OfferedItems.Contains(item)) {
                throw new Exception($"Item {item.Definition.Name} is not offered");
            }
            OfferedItems.Remove(item);
            OnStateChanged?.Invoke(this);
        }
        
        public void AddRequestedItem(IItem item)
        {
            if (RequestedItems.Contains(item)) {
                throw new Exception($"Item {item.Definition.Name} is already requested");
            }
            RequestedItems.Add(item);
            OnStateChanged?.Invoke(this);
        }
        
        public void RemoveRequestedItem(IItem item)
        {
            if (!RequestedItems.Contains(item)) {
                throw new Exception($"Item {item.Definition.Name} is not requested");
            }
            RequestedItems.Remove(item);
            OnStateChanged?.Invoke(this);
        }
    }
}