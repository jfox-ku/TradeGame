using UnityEngine;

namespace TradeGameNamespace.Views
{
    public abstract class SoViewDataLibrary<TObj, TViewData> : ScriptableObject, IViewDataLibrary<TObj,TViewData> where TViewData : IViewData
    {
        public abstract TViewData GetViewData(TObj obj);
    }
}