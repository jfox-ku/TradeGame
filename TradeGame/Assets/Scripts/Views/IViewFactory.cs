namespace TradeGameNamespace.Views
{
    public interface IViewFactory<out TView,TController,TViewData> where TView : IView<TController,TViewData> where TViewData : IViewData
    {
        TView Create();
    }
}