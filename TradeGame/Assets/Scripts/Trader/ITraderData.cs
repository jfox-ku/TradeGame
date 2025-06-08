namespace TradeGameNamespace.Trader
{
    public interface ITraderData
    {
        string TraderName { get; }
        ITraderPreferencesCollection PreferencesCollection { get; }

    }
}