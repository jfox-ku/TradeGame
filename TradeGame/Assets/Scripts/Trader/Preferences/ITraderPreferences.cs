using System.Collections.Generic;

namespace TradeGameNamespace.Trader
{
    public interface ITraderPreferences<T> : IEnumerable<T> where T : ITraderPreferenceType 
    {
        bool HasPreference(T type);
        float GetPreferenceStrength(T type);
        void SetPreferenceStrength(T type, float strength);
    }
}