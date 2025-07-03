namespace TradeGameNamespace
{
    public interface IFactory<out T>
    {
        T Create();
    }
}