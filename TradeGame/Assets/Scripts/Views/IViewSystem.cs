using TradeGameNamespace.Systems;

namespace TradeGameNamespace.Views
{
    public interface IViewSystem<in TObj, out TView, out TViewData> : ITickSystem
    {
        TView CreateView(TObj obj);
        TView GetView(TObj obj);
        TViewData GetViewData(TObj obj);
    }
}