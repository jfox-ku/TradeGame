using System.Collections.Generic;

namespace TradeGameNamespace.Items.ItemConditions
{
    public interface IItemConditionHandler
    {
        void AddCondition(IItemCondition condition);
        void RemoveCondition(IItemCondition condition);
        bool HasCondition<T>() where T : IItemCondition;
        T GetCondition<T>() where T : IItemCondition;
        IEnumerable<IItemCondition> GetAllConditions();
    }
}