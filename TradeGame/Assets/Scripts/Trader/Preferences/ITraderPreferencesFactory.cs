using System.Collections.Generic;

namespace TradeGameNamespace.Trader
{
    public interface ITraderPreferencesFactory<T> where T : ITraderPreferenceType
    {
        ITraderPreferences<T> CreatePreferences();
    }
   
}