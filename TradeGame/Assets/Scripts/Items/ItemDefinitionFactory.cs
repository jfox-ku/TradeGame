namespace TradeGameNamespace.Items
{
    public class ItemDefinitionFactory : IItemDefinitionFactory
    {
        public IItemDefinition Create() {
            return new ItemDefinition();
        }
    }
}