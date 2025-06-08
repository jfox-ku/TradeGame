using System;

namespace TradeGameNamespace.Trader
{
    public interface ITraderPreferenceData
    {
        Type PreferenceType { get; }
        float PreferenceStrength { get; set; }
    }
}