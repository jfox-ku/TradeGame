using System;
using TradeGameNamespace.Items.ItemConditions;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "TraderItemConditionPreferences", menuName = "Traders/TraderItemConditionPreferences")]
    public class SoTraderItemConditionPreferences : SoTraderPreferences<IItemCondition, TraderItemConditionPreferenceData>
    {
        
    }

    [Serializable]
    public class TraderItemConditionPreferenceData : TraderPreferenceData<IItemCondition>
    {
        
    }
}