using TradeGameNamespace.Inventory;
using TradeGameNamespace.Items;
using TradeGameNamespace.ValueSystem;

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
                value = EvaluateItem(item, value);
            }
            
            return value;
        }

        private float EvaluateItem(IItem item, float value) {
            value = EvaluateItemConditions(item, value);
            value = EvaluateItemCategories(item, value);
            return value;
        }

        private float EvaluateItemCategories(IItem item, float value) {
            foreach (var dataCategory in item.Definition.Categories) {
                var categoryPreferenceStrength = Data.PreferencesCollection.GetPreferenceStrength(dataCategory);
                value *= categoryPreferenceStrength;
            }
            return value;
        }

        private float EvaluateItemConditions(IItem item, float value) {
            foreach (var itemCondition in item.GetAllConditions()) {
                if (itemCondition is IValueEffector valueEffector) {
                    var conditionValueDelta = valueEffector.GetValueDelta(item.Definition.BaseValue);
                    conditionValueDelta *= Data.PreferencesCollection.GetPreferenceStrength(itemCondition);
                    value += conditionValueDelta;
                }
            }

            return value;
        }
    }
}