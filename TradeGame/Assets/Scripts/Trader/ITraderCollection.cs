using System.Collections.Generic;

namespace TradeGameNamespace.Trader
{
    public interface ITraderCollection : IReadOnlyList<ITrader>
    {
        static ITraderCollection Default =>
            new TraderCollection(new List<ITrader>());
    }
}