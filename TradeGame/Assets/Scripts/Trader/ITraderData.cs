namespace TradeGameNamespace.Trader
{
    public interface ITraderData
    {
        int Patience { get; }
        ITraderPreferencesCollection PreferencesCollection { get; }

    }
}