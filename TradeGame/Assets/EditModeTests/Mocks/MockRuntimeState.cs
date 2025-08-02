using System;
using TradeGameNamespace.RuntimeState;

namespace EditModeTests.Mocks
{
    public class MockRuntimeState : IRuntimeState
    {
        public event Action<IRuntimeState> OnStateChanged;
        
        public RuntimeStateID StateID => (RuntimeStateID) _stateID;
        
        private readonly RuntimeStateID _stateID;
        
        public MockRuntimeState(RuntimeStateID stateID)
        {
            _stateID = stateID;
        }
       
        
    }
}