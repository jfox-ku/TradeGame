namespace TradeGameNamespace.Items
{
    public class ItemAbstractFactory : IItemFactory
    {
        private readonly IItemDefinitionFactory _itemDefinitionFactory;
        
        public ItemAbstractFactory(IItemDefinitionFactory itemDefinitionFactory) {
            _itemDefinitionFactory = itemDefinitionFactory;
        }
        
        public IItem Create() {
            var itemDefinition = _itemDefinitionFactory.Create();
            var conditionsFactory = itemDefinition.ConditionsFactory ?? IItemConditionsFactory.Default;
            
            return new Item(
                _itemDefinitionFactory.Create(),
                conditionsFactory.Create()
            );
        }
    }
}