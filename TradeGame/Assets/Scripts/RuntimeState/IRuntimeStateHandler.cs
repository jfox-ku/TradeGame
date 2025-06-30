using System;

namespace TradeGameNamespace.RuntimeState
{
    public interface IRuntimeStateHandler
    {
        event Action<IRuntimeState> OnRuntimeStateChanged;
        void AddRuntimeState(IRuntimeState runtimeState);
        void RemoveRuntimeState(RuntimeStateID runtimeState);
        bool HasRuntimeState(RuntimeStateID stateID);
        IRuntimeState GetRuntimeState(RuntimeStateID stateID);
    }
}