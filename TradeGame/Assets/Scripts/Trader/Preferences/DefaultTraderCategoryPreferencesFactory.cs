using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;

namespace DefaultNamespace.Trader
{
    public class DefaultTraderCategoryPreferencesFactory : ITraderPreferencesFactory<IItemCategory>
    {
        public ITraderPreferences<IItemCategory> CreatePreferences() {
            return new TraderPreferences<IItemCategory>();
        }
    }
}