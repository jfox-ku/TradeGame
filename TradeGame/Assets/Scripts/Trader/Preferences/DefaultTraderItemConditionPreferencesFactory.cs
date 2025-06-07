using DefaultNamespace.Items.ItemConditions;

namespace DefaultNamespace.Trader
{
    public class DefaultTraderItemConditionPreferencesFactory : ITraderPreferencesFactory<IItemCondition>
    {
        public ITraderPreferences<IItemCondition> CreatePreferences() {
            return new TraderPreferences<IItemCondition>();
        }
    }
}