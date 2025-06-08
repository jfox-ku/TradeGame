using TradeGameNamespace.Systems;

namespace TradeGameNamespace.Features.TimeOfDay
{
    public class TimeOfDaySystem : ITickSystem
    {
        ITimeOfDaySystemData _data;
        
        private float _currentTime;
        private float MaxTime => _data.DayDuration;
        private float CurrentTime => _currentTime % MaxTime;
        private float LightIntensity => _data.TimeToLightIntensity(CurrentTime);
        
        public TimeOfDaySystem(ITimeOfDaySystemData data) {
            _data = data;
        }

        public void Tick(float deltaTime) {
           _currentTime += deltaTime;
        }

        public void Initialize(ISystemHandler systemHandler) {
            _currentTime = 0;
        }
    }
}