using System.Collections.Generic;

namespace DefaultNamespace.Items
{
    public class ItemAbstractFactory : IItemFactory
    {
        private readonly IItemDataFactory _itemDataFactory;
        private readonly IItemConditionsFactory _conditionsFactory;
        
        public ItemAbstractFactory(IItemDataFactory itemDataFactory, IItemConditionsFactory conditionsFactory) {
            _itemDataFactory = itemDataFactory;
            _conditionsFactory = conditionsFactory;
        }
        
        public IItem CreateItem() {
            return new Item(
                _itemDataFactory.CreateItemData(),
                _conditionsFactory.CreateItemConditions()
            );
        }
    }
}