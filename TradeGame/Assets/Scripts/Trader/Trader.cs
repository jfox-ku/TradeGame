using TradeGameNamespace.Inventory;
using TradeGameNamespace.Items;
using TradeGameNamespace.ValueSystem;
using UnityEngine;

namespace TradeGameNamespace.Trader
{
    public class Trader : ITrader
    {
        public IInventory Inventory { get; }
        public IInventory InTradeInventory { get; }
        public ITraderData Data { get; }

        public Trader(IInventory inventory,  ITraderData data)
        {
            Inventory = inventory;
            InTradeInventory = new EmptyInventoryFactory().CreateInventoryOfCapacity(4);
            Data = data;
        }
        
        public float Evaluate(IValuable valuable) {
            var value = valuable.Value;
            
            if(valuable is IItem item) {
                value = EvaluateItem(item);
            }
            
            return value;
        }

        private float EvaluateItem(IItem item) {
            var conditionsValue = EvaluateItemConditions(item);
            var categoriesValue = EvaluateItemCategories(item);
            return Mathf.Max(0, item.Value + conditionsValue + categoriesValue);
        }

        private float EvaluateItemCategories(IItem item) {
            var value = 0f;
            foreach (var dataCategory in item.Definition.Categories) {
                var categoryPreferenceValueDelta = item.Definition.BaseValue * Data.PreferencesCollection.GetPreferenceStrength(dataCategory);
                value += categoryPreferenceValueDelta;
            }
            return value;
        }

        private float EvaluateItemConditions(IItem item) {
            var value = 0f;
            foreach (var itemCondition in item.GetAllConditions()) {
                if (itemCondition is IValueEffector valueEffector) {
                    var conditionValueDelta = valueEffector.GetValueDelta(item.Definition.BaseValue);
                    conditionValueDelta *= Data.PreferencesCollection.GetPreferenceStrength(itemCondition);
                    value += (conditionValueDelta);
                }
            }

            return value;
        }
    }
}