namespace TradeGameNamespace.Items
{
    public class DefaultItemFactory : IItemFactory
    {
        public IItem Create() {
            return new Item(IItemDefinition.Default);
        }
    }
}