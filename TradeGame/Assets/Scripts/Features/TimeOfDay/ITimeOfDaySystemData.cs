

using System;

namespace TradeGameNamespace.Features.TimeOfDay
{
    public interface ITimeOfDaySystemData
    {
        float DayDuration { get; }
        Func<float, float> TimeToLightIntensity { get; }
        
    }
}