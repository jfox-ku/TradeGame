using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Trader
{
    public class DefaultTraderItemConditionPreferencesFactory : ITraderPreferencesFactory<IItemCondition>
    {
        public ITraderPreferences<IItemCondition> CreatePreferences() {
            return new TraderPreferences<IItemCondition>();
        }
    }
}