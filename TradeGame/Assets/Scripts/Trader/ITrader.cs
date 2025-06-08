using DefaultNamespace.Inventory;
using DefaultNamespace.ValueSystem;

namespace DefaultNamespace.Trader
{
    public interface ITrader : IValueEvaluator
    {
        IInventory Inventory { get; }
        IInventory InTradeInventory { get; }
        ITraderData Data { get; }
        
        
    }
}