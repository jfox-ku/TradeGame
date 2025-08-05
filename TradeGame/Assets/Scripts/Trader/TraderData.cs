using TradeGameNamespace.Trader;

namespace TradeGameNamespace.Trader
{
    public class TraderData : ITraderData
    {
        public string TraderName { get; }
        public int Patience { get; }
        public ITraderPreferencesCollection PreferencesCollection { get; }
        
        public TraderData(string traderName, int patience, ITraderPreferencesCollection preferencesCollection)
        {
            TraderName = traderName;
            Patience = patience;
            PreferencesCollection = preferencesCollection;
        }

        public static TraderData CreatePlayerTraderData() {
            return new TraderData("Player", 0, new TraderPreferencesCollection());
        }
    }
}