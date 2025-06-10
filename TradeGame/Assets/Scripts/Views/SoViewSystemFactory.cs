using UnityEngine;

namespace TradeGameNamespace.Views
{
    public abstract class SoViewSystemFactory<TViewSystem, TObj, TView, TViewData>  : ScriptableObject, IViewSystemFactory<TViewSystem,TObj, TView,TViewData> 
        where TViewSystem : IViewSystem<TObj, TView, TViewData> 
        where TView : IView<TView, IViewData>
    {
        public abstract IViewSystem<TObj, TView, TViewData> CreateSystem();
    }
}