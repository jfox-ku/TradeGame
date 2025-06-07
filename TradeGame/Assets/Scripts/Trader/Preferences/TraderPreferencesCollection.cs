using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;
using DefaultNamespace.Items.ItemConditions;

namespace DefaultNamespace.Trader
{
    public class TraderPreferencesCollection : ITraderPreferencesCollection
    {
        public ITraderPreferences<IItemCategory> CategoryPreferences { get; }
        public ITraderPreferences<IItemCondition> ConditionPreferences { get; }


        public float GetPreferenceStrength<T>(T preferenceType) where T : ITraderPreferenceType {

            if (preferenceType is IItemCategory categoryPreference) {
                CategoryPreferences.GetPreferenceStrength(categoryPreference);
            }
            
            if (preferenceType is IItemCondition conditionPreference) {
                return ConditionPreferences.GetPreferenceStrength(conditionPreference);
            }

            return 0;
        }

        public IEnumerable<ITraderPreferenceType> GetAllPreferences() {
            foreach (var category in CategoryPreferences)
            {
                yield return category;
            }

            foreach (var condition in ConditionPreferences)
            {
                yield return condition;
            }
        }

        public TraderPreferencesCollection() {
            CategoryPreferences = new DefaultTraderCategoryPreferencesFactory().CreatePreferences();
            ConditionPreferences = new DefaultTraderItemConditionPreferencesFactory().CreatePreferences();
        }

        public TraderPreferencesCollection(ITraderPreferences<IItemCategory> categoryPreferences, ITraderPreferences<IItemCondition> conditionPreferences)
        {
            CategoryPreferences = categoryPreferences;
            ConditionPreferences = conditionPreferences;
        }
    }
}