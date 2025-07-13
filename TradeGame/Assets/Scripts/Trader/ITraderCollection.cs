using System.Collections.Generic;
using TradeGameNamespace.Trader;

namespace Trader
{
    public interface ITraderCollection : IReadOnlyList<ITrader>
    {
        static ITraderCollection Default =>
            new TraderCollection(new List<ITrader>());
    }
}