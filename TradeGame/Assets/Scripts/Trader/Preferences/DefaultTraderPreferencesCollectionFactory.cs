using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;
using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Trader
{
    public class DefaultTraderPreferencesCollectionFactory : ITraderPreferencesCollectionFactory
    {
        public ITraderPreferencesCollection CreateTraderPreferences() {
            return new TraderPreferencesCollection();
        }
    }
}