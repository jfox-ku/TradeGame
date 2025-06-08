using TradeGameNamespace.Trader;

namespace TradeGameNamespace.Items.ItemCategories
{
    public interface IItemCategory : ITraderPreferenceType
    {
        string Name { get; }
        
    }
}