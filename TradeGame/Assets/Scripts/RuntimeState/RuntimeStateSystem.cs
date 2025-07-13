using System;
using System.Collections.Generic;
using TradeGameNamespace.Systems;

namespace TradeGameNamespace.RuntimeState
{
    public class RuntimeStateSystem : IRuntimeStateHandlerSystem
    {
        public event Action<IRuntimeState> OnRuntimeStateChanged;
        
        private Dictionary<int, IRuntimeState> _runtimeStates = new Dictionary<int, IRuntimeState>();
        
        public void AddRuntimeState(IRuntimeState runtimeState) {
            if(HasRuntimeState(runtimeState.StateID)) {
                throw new InvalidOperationException($"Runtime state with ID {runtimeState.StateID} already exists.");
            }
            
            runtimeState.OnStateChanged += OnRuntimeStateChanged;
            _runtimeStates.Add((int)runtimeState.StateID, runtimeState);
        }

        public void RemoveRuntimeState(RuntimeStateID runtimeState) {
            if(!HasRuntimeState(runtimeState)) {
                throw new InvalidOperationException($"Runtime state with ID {runtimeState} does not exist.");
            }
            
            var state = GetRuntimeState(runtimeState);
            if (state == null) {
                throw new InvalidOperationException($"Runtime state with ID {runtimeState} is null.");
            }
            
            state.OnStateChanged -= OnRuntimeStateChanged;
            _runtimeStates.Remove((int)runtimeState);
            
        }

        public bool HasRuntimeState(RuntimeStateID stateID) {
            return GetRuntimeState(stateID) != null;
        }

        public IRuntimeState GetRuntimeState(RuntimeStateID stateID) {
            _runtimeStates.TryGetValue((int)stateID, out var runtimeState);
            return runtimeState;
        }

        public void Initialize(ISystemHandler systemHandler) {
            _runtimeStates = new Dictionary<int, IRuntimeState>();
        }
    }
}