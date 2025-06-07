using DefaultNamespace.Trader;

namespace DefaultNamespace.Items.ItemCategories
{
    public interface IItemCategory : ITraderPreferenceType
    {
        string Name { get; }
        
    }
}