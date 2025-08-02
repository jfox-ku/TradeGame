using System.Collections.Generic;

namespace TradeGameNamespace.Items.ItemCategories
{
    public static class ItemCategoryUtility
    {
        public static IEnumerable<IItemCategory> GetCommonCategories(this IList<IItemCategory> categoriesSource, IList<IItemCategory> categoriesCompareTarget)
        {
            foreach (var source in categoriesSource)
            {
                foreach (var target in categoriesCompareTarget) {
                    if (!source.Equals(target)) continue;
                    yield return source;
                    break;
                }
            }
        }
    }
}