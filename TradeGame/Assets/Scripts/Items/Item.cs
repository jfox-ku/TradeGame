using System.Collections.Generic;
using TradeGameNamespace.Items.ItemConditions;

namespace TradeGameNamespace.Items
{
    public class Item : IItem
    {
        public float Value => Data.BaseValue;
        public IItemData Data { get; }
        
        private List<IItemCondition> Conditions { get; }
        
        public Item(IItemData data) {
            Data = data;
            Conditions = new List<IItemCondition>();
        }
        
        public Item(IItemData data, List<IItemCondition> conditions) {
            Data = data;
            Conditions = conditions;
        }
        
        public void AddCondition(IItemCondition condition) {
            if (condition == null) {
                throw new System.ArgumentNullException(nameof(condition), "Condition cannot be null.");
            }
            if (Conditions.Contains(condition)) {
                throw new System.InvalidOperationException("Condition already exists.");
            }
            Conditions.Add(condition);
        }

        public void RemoveCondition(IItemCondition condition) {
            if (condition == null) {
                throw new System.ArgumentNullException(nameof(condition), "Condition cannot be null.");
            }
            if (!Conditions.Contains(condition)) {
                throw new System.InvalidOperationException("Condition does not exist.");
            }
            Conditions.Remove(condition);
        }

        public bool HasCondition<T>() where T : IItemCondition {
            foreach (var itemCondition in Conditions) {
                if (itemCondition is T castCondition) {
                    return true;
                }
            }

            return false;
        }

        public T GetCondition<T>() where T : IItemCondition {
            foreach (var itemCondition in Conditions) {
                if (itemCondition is T castCondition) {
                    return castCondition;
                }
            }

            throw new System.InvalidOperationException($"Condition of type {typeof(T)} not found.");
        }

        public IEnumerable<IItemCondition> GetAllConditions() {
            return Conditions;
        }

       
    }
}