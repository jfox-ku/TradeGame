using System;
using TradeGameNamespace.RuntimeState.States;

namespace TradeGameNamespace.RuntimeState
{
    public static class RuntimeStateExtensions
    {
        public static PlayerInventoryValueState GetPlayerInventoryValueState(this IRuntimeStateHandlerSystem runtimeStateHandlerSystem)
        {
            var state = runtimeStateHandlerSystem.GetRuntimeState(RuntimeStateID.PlayerInventoryValue);
            if (state is PlayerInventoryValueState playerInventoryValueState)
            {
                return playerInventoryValueState;
            }

            throw new Exception("RuntimeStateHandler does not contain a PlayerInventoryValueState.");
        }
        
        public static PlayerInventoryState GetPlayerInventoryState(this IRuntimeStateHandlerSystem runtimeStateHandlerSystem)
        {
            var state = runtimeStateHandlerSystem.GetRuntimeState(RuntimeStateID.PlayerInventoryState);
            if (state is PlayerInventoryState playerInventoryState)
            {
                return playerInventoryState;
            }

            throw new Exception("RuntimeStateHandler does not contain a PlayerInventoryState.");
        }
        
        public static PlayerLocationState GetPlayerLocationState(this IRuntimeStateHandlerSystem runtimeStateHandlerSystem)
        {
            var state = runtimeStateHandlerSystem.GetRuntimeState(RuntimeStateID.PlayerLocation);
            if (state is PlayerLocationState playerLocationState)
            {
                return playerLocationState;
            }

            throw new Exception("RuntimeStateHandler does not contain a PlayerLocationState.");
        }
        
        public static TalkToTraderState GetTalkToTraderState(this IRuntimeStateHandlerSystem runtimeStateHandlerSystem)
        {
            var state = runtimeStateHandlerSystem.GetRuntimeState(RuntimeStateID.TalkToTrader);
            if (state is TalkToTraderState talkToTraderState)
            {
                return talkToTraderState;
            }

            throw new Exception("RuntimeStateHandler does not contain a TalkToTraderState.");
        }
    }
}