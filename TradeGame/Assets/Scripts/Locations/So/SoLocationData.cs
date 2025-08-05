using TradeGameNamespace.Items;
using TradeGameNamespace.Trader;
using UnityEngine;


namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "LocationData", menuName = "Location/LocationData")]
    public class SoLocationData : ScriptableObject, ILocationData
    {
        [SerializeField]
        private InterfaceReference<ITraderCollection> traderCollection;
        [SerializeField]
        private InterfaceReference<IItemCollection> itemCollection;

        public ITraderCollection TraderCollection => traderCollection.Value;
        public IItemCollection ItemCollection => itemCollection.Value;
    }
}