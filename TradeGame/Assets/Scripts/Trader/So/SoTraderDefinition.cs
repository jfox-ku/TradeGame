using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "TraderDefinition", menuName = "Traders/TraderDefinition")]
    public class SoTraderDefinition : ScriptableObject, ITraderDefinition
    {
        [SerializeField]
        private string traderName;
        [SerializeField]
        private InterfaceReference<ITraderData> dataReference = new InterfaceReference<ITraderData>();
        
        public string TraderName => traderName;
        public ITraderData Data => dataReference.Value;
    }
}