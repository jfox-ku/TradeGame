namespace TradeGameNamespace.Views
{
    public interface IViewDataFactory<out TViewData> where TViewData : IViewData
    {
        TViewData Create();
    }
}