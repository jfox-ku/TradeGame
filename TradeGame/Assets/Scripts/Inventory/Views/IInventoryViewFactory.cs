using TradeGameNamespace.Views;

namespace TradeGameNamespace.Inventory.Views
{
    public interface IInventoryViewFactory : IViewFactory<IInventoryView, IInventory, IInventoryViewData> { }
}