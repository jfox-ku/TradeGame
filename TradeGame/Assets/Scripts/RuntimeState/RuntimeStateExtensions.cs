﻿using System;
using TradeGameNamespace.RuntimeState.States;

namespace TradeGameNamespace.RuntimeState
{
    public static class RuntimeStateExtensions
    {
        public static PlayerInventoryValueState GetPlayerInventoryValueState(this IRuntimeStateHandler runtimeStateHandler)
        {
            var state = runtimeStateHandler.GetRuntimeState(RuntimeStateID.PlayerInventoryValue);
            if (state is PlayerInventoryValueState playerInventoryValueState)
            {
                return playerInventoryValueState;
            }

            throw new Exception("RuntimeStateHandler does not contain a PlayerInventoryValueState.");
        }
    }
}