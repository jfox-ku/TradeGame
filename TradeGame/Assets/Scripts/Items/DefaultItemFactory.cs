namespace TradeGameNamespace.Items
{
    public class DefaultItemFactory : IItemFactory
    {
        public IItem CreateItem() {
            return new Item(new ItemData());
        }
    }
}