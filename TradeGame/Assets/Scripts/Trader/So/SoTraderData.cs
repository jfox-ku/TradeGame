using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    public class SoTraderData : ScriptableObject, ITraderData
    {
        [SerializeField]
        private string traderName;
        [SerializeField]
        private int patience;
        [SerializeField]
        InterfaceReference<ITraderPreferencesCollection> traderPreferencesCollection = new InterfaceReference<ITraderPreferencesCollection>();

        public string TraderName => traderName;
        public int Patience => patience;
        public ITraderPreferencesCollection PreferencesCollection => traderPreferencesCollection.Value;
    }
}