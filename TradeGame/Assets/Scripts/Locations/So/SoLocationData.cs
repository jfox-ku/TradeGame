using TradeGameNamespace.Items;
using TradeGameNamespace.Trader.So;
using Trader;
using UnityEngine;
using UnityEngine.Serialization;

namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "LocationData", menuName = "Location/LocationData")]
    public class SoLocationData : ScriptableObject, ILocationData
    {
        [FormerlySerializedAs("traderFactory")]
        [SerializeField]
        private InterfaceReference<ITraderCollection> traderCollection;
        [FormerlySerializedAs("itemFactory")]
        [SerializeField]
        private InterfaceReference<IItemCollection> itemCollection;

        public ITraderCollection TraderCollection => traderCollection.Value;
        public IItemCollection ItemCollection => itemCollection.Value;
    }
}