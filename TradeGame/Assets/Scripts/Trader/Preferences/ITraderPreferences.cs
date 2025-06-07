using System.Collections.Generic;

namespace DefaultNamespace.Trader
{
    public interface ITraderPreferences<T> : IEnumerable<T> where T : ITraderPreferenceType 
    {
        bool HasPreference(T type);
        float GetPreferenceStrength(T type);
    }
}