using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;
using DefaultNamespace.Items.ItemConditions;

namespace DefaultNamespace.Trader
{
    public class DefaultTraderPreferencesCollectionFactory : ITraderPreferencesCollectionFactory
    {
        public ITraderPreferencesCollection CreateTraderPreferences() {
            return new TraderPreferencesCollection();
        }
    }
}