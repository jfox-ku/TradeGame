using System.Collections.Generic;

namespace TradeGameNamespace.Items
{
    public class ItemAbstractFactory : IItemFactory
    {
        private readonly IItemDefinitionFactory _itemDefinitionFactory;
        private readonly IItemConditionsFactory _conditionsFactory;
        
        public ItemAbstractFactory(IItemDefinitionFactory itemDefinitionFactory, IItemConditionsFactory conditionsFactory) {
            _itemDefinitionFactory = itemDefinitionFactory;
            _conditionsFactory = conditionsFactory;
        }
        
        public IItem CreateItem() {
            return new Item(
                _itemDefinitionFactory.Create(),
                _conditionsFactory.Create()
            );
        }
    }
}