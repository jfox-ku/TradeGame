using System;
using TradeGameNamespace.Systems;

namespace TradeGameNamespace.RuntimeState
{
    public interface IRuntimeStateHandlerSystem : ISystem
    {
        event Action<IRuntimeState> OnRuntimeStateChanged;
        void AddRuntimeState(IRuntimeState runtimeState);
        void RemoveRuntimeState(RuntimeStateID runtimeState);
        bool HasRuntimeState(RuntimeStateID stateID);
        IRuntimeState GetRuntimeState(RuntimeStateID stateID);
    }
}