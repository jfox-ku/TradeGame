using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;

namespace TradeGameNamespace.Trader
{
    public class DefaultTraderCategoryPreferencesFactory : ITraderPreferencesFactory<IItemCategory>
    {
        public ITraderPreferences<IItemCategory> CreatePreferences() {
            return new TraderPreferences<IItemCategory>();
        }
    }
}