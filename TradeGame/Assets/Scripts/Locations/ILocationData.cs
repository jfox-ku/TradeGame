using TradeGameNamespace.Items;
using TradeGameNamespace.Trader.So;
using Trader;

namespace TradeGameNamespace.Locations
{
    public interface ILocationData
    {
        ITraderCollection TraderCollection { get; }
        IItemCollection ItemCollection { get; }

        static ILocationData Default {
            get {
                return new LocationData(ITraderCollection.Default, IItemCollection.Default);
            }
        }
    }
}