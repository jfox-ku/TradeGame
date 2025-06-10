namespace TradeGameNamespace.Views
{
    public interface IViewDataLibrary<in TObj, out TViewData> where TViewData : IViewData
    {
        public TViewData GetViewData(TObj obj);
    }
}