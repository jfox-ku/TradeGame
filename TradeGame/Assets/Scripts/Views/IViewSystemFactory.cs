using TradeGameNamespace.Systems;

namespace TradeGameNamespace.Views
{
    public interface IViewSystemFactory<TViewSystem, in TObj, out TView, out TViewData> : ISystemFactory<IViewSystem<TObj,TView,TViewData>>
        where TViewSystem : IViewSystem<TObj,TView,TViewData> 
        where TView : IView<TView, IViewData>
    {
       
    }
}