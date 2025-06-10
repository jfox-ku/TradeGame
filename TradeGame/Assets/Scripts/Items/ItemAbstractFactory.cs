using System.Collections.Generic;

namespace TradeGameNamespace.Items
{
    public class ItemAbstractFactory : IItemFactory
    {
        private readonly IItemDefinitionFactory _ıtemDefinitionFactory;
        private readonly IItemConditionsFactory _conditionsFactory;
        
        public ItemAbstractFactory(IItemDefinitionFactory ıtemDefinitionFactory, IItemConditionsFactory conditionsFactory) {
            _ıtemDefinitionFactory = ıtemDefinitionFactory;
            _conditionsFactory = conditionsFactory;
        }
        
        public IItem CreateItem() {
            return new Item(
                _ıtemDefinitionFactory.CreateItemData(),
                _conditionsFactory.CreateItemConditions()
            );
        }
    }
}