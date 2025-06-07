using DefaultNamespace.Inventory;
using DefaultNamespace.ValueSystem;

namespace DefaultNamespace.Trader
{
    public interface ITrader : IValueEvaluator
    {
        IInventory Inventory { get; }
        IInventory TradeInventory { get; }
        ITraderData Data { get; }
        
        
    }
}