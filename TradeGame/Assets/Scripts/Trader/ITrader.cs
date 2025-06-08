using TradeGameNamespace.Inventory;
using TradeGameNamespace.ValueSystem;

namespace TradeGameNamespace.Trader
{
    public interface ITrader : IValueEvaluator
    {
        IInventory Inventory { get; }
        IInventory InTradeInventory { get; }
        ITraderData Data { get; }
        
        
    }
}