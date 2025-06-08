using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;
using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Trader
{
    public interface ITraderPreferencesCollection
    {
        ITraderPreferences<IItemCategory> CategoryPreferences { get; }
        ITraderPreferences<IItemCondition> ConditionPreferences { get; }
        
        float GetPreferenceStrength<T>(T preferenceType) where T : ITraderPreferenceType;
        public IEnumerable<ITraderPreferenceType> GetAllPreferences();
    }
}