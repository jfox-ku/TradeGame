namespace DefaultNamespace.Trader
{
    public interface ITraderData
    {
        string TraderName { get; }
        ITraderPreferencesCollection PreferencesCollection { get; }

    }
}