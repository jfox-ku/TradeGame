using System;

namespace TradeGameNamespace.RuntimeState
{
    public interface IRuntimeState
    {
        event Action<IRuntimeState> OnStateChanged;
        RuntimeStateID StateID { get; }
    }
}