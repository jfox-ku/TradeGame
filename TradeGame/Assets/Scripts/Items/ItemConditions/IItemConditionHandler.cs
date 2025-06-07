using System.Collections.Generic;

namespace DefaultNamespace.Items.ItemConditions
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