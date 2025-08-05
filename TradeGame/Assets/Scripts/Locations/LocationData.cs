using TradeGameNamespace.Items;
using TradeGameNamespace.Trader;

namespace TradeGameNamespace.Locations
{
    public class LocationData : ILocationData
    {
        public ITraderCollection TraderCollection { get; }
        public IItemCollection ItemCollection { get; }

        public LocationData(ITraderCollection traderCollection, IItemCollection itemCollection) {
            TraderCollection = traderCollection;
            ItemCollection = itemCollection;
        }
    }
}