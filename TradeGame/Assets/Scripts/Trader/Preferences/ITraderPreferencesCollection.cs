using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;
using DefaultNamespace.Items.ItemConditions;

namespace DefaultNamespace.Trader
{
    public interface ITraderPreferencesCollection
    {
        ITraderPreferences<IItemCategory> CategoryPreferences { get; }
        ITraderPreferences<IItemCondition> ConditionPreferences { get; }
        
        float GetPreferenceStrength<T>(T preferenceType) where T : ITraderPreferenceType;
        public IEnumerable<ITraderPreferenceType> GetAllPreferences();
    }
}