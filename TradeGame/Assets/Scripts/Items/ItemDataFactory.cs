namespace TradeGameNamespace.Items
{
    public class ItemDataFactory : IItemDataFactory
    {
        public IItemData CreateItemData() {
            return new ItemData();
        }
    }
}