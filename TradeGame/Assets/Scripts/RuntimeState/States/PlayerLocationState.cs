using System;
using TradeGameNamespace.Locations;

namespace TradeGameNamespace.RuntimeState.States
{
    [Serializable]
    public class PlayerLocationState : IRuntimeState
    {
        public event Action<IRuntimeState> OnStateChanged;
        public RuntimeStateID StateID => RuntimeStateID.PlayerLocation;
        
        public ILocation CurrentLocation { get; private set; }
        
        public PlayerLocationState(ILocation initialLocation)
        {
            CurrentLocation = initialLocation;
        }
        
        public void SetLocation(ILocation newLocation) {
            if (CurrentLocation == newLocation) return;
            CurrentLocation = newLocation;
            OnStateChanged?.Invoke(this);
        }
        
        
    }
}