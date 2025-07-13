namespace TradeGameNamespace.Trader
{
    public interface ITraderData
    {
        string TraderName { get; }
        int Patience { get; }
        ITraderPreferencesCollection PreferencesCollection { get; }

    }
}