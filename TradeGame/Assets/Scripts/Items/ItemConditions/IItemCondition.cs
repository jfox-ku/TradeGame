using DefaultNamespace.Trader;
using DefaultNamespace.ValueSystem;

namespace DefaultNamespace.Items.ItemConditions
{
    public interface IItemCondition: IValueEffector, ITraderPreferenceType
    {
        string Name { get; }
        
    }
}