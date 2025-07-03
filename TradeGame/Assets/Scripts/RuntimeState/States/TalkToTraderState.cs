using System;
using TradeGameNamespace.Trader;

namespace TradeGameNamespace.RuntimeState.States
{
    public class TalkToTraderState : IRuntimeState
    {
        public event Action<IRuntimeState> OnStateChanged;
        public RuntimeStateID StateID => RuntimeStateID.TalkToTrader;
        
        public ITrader CurrentTrader { get; private set; }
        
        public TalkToTraderState(ITrader trader)
        {
            CurrentTrader = trader;
        }
        
        public void SetTrader(ITrader newTrader)
        {
            if (CurrentTrader == newTrader) return;
            CurrentTrader = newTrader;
            OnStateChanged?.Invoke(this);
        }
        
    }
}