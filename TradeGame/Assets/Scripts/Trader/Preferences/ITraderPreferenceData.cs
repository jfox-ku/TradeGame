using System;

namespace DefaultNamespace.Trader
{
    public interface ITraderPreferenceData
    {
        Type PreferenceType { get; }
        float PreferenceStrength { get; set; }
    }
}