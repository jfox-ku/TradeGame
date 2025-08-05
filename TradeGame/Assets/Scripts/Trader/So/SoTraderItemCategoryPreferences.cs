using System;
using TradeGameNamespace.Items.ItemCategories;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "TraderItemCategoryPreferences", menuName = "Traders/TraderItemCategoryPreferences")]
    public class SoTraderItemCategoryPreferences : SoTraderPreferences<IItemCategory,TraderItemCategoryPreferenceData>
    {
        
    }
    
    [Serializable]
    public class TraderItemCategoryPreferenceData : TraderPreferenceData<IItemCategory>
    {
       
    }

}