

using System;

namespace DefaultNamespace.Features.TimeOfDay
{
    public interface ITimeOfDaySystemData
    {
        float DayDuration { get; }
        Func<float, float> TimeToLightIntensity { get; }
        
    }
}