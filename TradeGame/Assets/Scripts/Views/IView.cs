namespace TradeGameNamespace.Views
{
    public interface IView<in T, in K> where K : IViewData
    {
        void AssignController(T controller);
        void AssignData(K data);
    }
}