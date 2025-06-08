using TradeGameNamespace.Trader;
using TradeGameNamespace.ValueSystem;

namespace TradeGameNamespace.Items.ItemConditions
{
    public interface IItemCondition: IValueEffector, ITraderPreferenceType
    {
        string Name { get; }
        
    }
}