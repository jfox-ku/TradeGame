using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;
using TradeGameNamespace.Items.ItemConditions;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "TraderPreferencesCollection", menuName = "Traders/TraderPreferencesCollection")]
    public class SoTraderPreferencesCollection : ScriptableObject, ITraderPreferencesCollection
    {
        private TraderPreferencesCollection _internalCollection;
        
        [SerializeField]
        private InterfaceReference<ITraderPreferences<IItemCategory>> categoryPreferences = new InterfaceReference<ITraderPreferences<IItemCategory>>();
        private ITraderPreferences<IItemCategory> _categoryPreferences;
        [SerializeField]
        private InterfaceReference<ITraderPreferences<IItemCondition>> conditionPreferences = new InterfaceReference<ITraderPreferences<IItemCondition>>();
        private ITraderPreferences<IItemCondition> _conditionPreferences;
        
        private TraderPreferencesCollection InternalCollection {
            get { return _internalCollection ??= new TraderPreferencesCollection(CategoryPreferences, ConditionPreferences); }
        }
        
        public ITraderPreferences<IItemCategory> CategoryPreferences {
            get { return _categoryPreferences ??= categoryPreferences.Value; }
        }

        public ITraderPreferences<IItemCondition> ConditionPreferences {
            get { return _conditionPreferences ??= conditionPreferences.Value; }
        }

        public float GetPreferenceStrength<T>(T preferenceType) where T : ITraderPreferenceType {
            return InternalCollection.GetPreferenceStrength(preferenceType);
        }

        public IEnumerable<ITraderPreferenceType> GetAllPreferences() {
            return InternalCollection.GetAllPreferences();
        }
    }
}