using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "Trader Data", menuName = "Traders/Trader Data")]
    public class SoTraderData : ScriptableObject, ITraderData
    {
        [SerializeField]
        private int patience;
        [SerializeField]
        InterfaceReference<ITraderPreferencesCollection> traderPreferencesCollection = new InterfaceReference<ITraderPreferencesCollection>();
        
        public int Patience => patience;
        public ITraderPreferencesCollection PreferencesCollection => traderPreferencesCollection.Value;
    }
}