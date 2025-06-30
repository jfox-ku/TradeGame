using System;

namespace TradeGameNamespace.RuntimeState
{
    public interface IRuntimeState
    {
        event Action OnStateChanged;
        RuntimeStateID StateID { get; }
    }
}