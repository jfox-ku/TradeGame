using DefaultNamespace.Systems;

namespace DefaultNamespace.Features.TimeOfDay
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
        
        public void Initialize() {
            _currentTime = 0;
        }

        public void Tick(float deltaTime) {
           _currentTime += deltaTime;
        }
    }
}