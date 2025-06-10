namespace TradeGameNamespace.Views
{
    public interface IViewFactory<out TView, in TObj, in TViewData> where TView : IView<TObj,TViewData> where TViewData : IViewData
    {
        TView Create();
        TView Create(TObj obj, TViewData data);
    }
}