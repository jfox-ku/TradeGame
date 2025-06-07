using System.Collections.Generic;

namespace DefaultNamespace.Trader
{
    public interface ITraderPreferencesFactory<T> where T : ITraderPreferenceType
    {
        ITraderPreferences<T> CreatePreferences();
    }
   
}