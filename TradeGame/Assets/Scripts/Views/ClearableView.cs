namespace TradeGameNamespace.Views
{
    public abstract class ClearableView<T,K> : View<T,K> where K: IViewData
    {
        public void Clear() {
            if (_controller == null) return;
            _controller = default;
            OnClear();
        }

        protected abstract void OnClear();
    }
}