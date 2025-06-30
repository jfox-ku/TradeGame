using TradeGameNamespace.Items;
using TradeGameNamespace.Trader.So;

namespace TradeGameNamespace.Locations
{
    public interface ILocationData
    {
        ITraderFactory TraderFactory { get; }
        IItemFactory ItemFactory { get; }
    }
}