namespace TradeGameNamespace.Items
{
    public class ItemDefinitionFactory : IItemDefinitionFactory
    {
        public IItemDefinition CreateItemData() {
            return new ItemDefinition();
        }
    }
}