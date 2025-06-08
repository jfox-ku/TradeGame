using UnityEngine;

namespace TradeGameNamespace.Views
{
    public abstract class View<T,K> : MonoBehaviour, IView<T,K> where K : IViewData
    {
        protected T _controller;
        protected K _data;
        
        public void AssignController(T controller) {
            _controller = controller;
            OnControllerAssigned();
        }

        public void AssignData(K data) {
            _data = data;
            OnDataAssigned();
        }

        protected abstract void OnControllerAssigned();
        protected abstract void OnDataAssigned();
    }
}