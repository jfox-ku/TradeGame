namespace TradeGameNamespace
{
    public interface IParameterizedFactory<in TParameter, out TResult>
    {
        TResult CreateInventoryForTrader(TParameter parameter);
    }
}