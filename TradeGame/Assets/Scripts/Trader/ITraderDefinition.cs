namespace TradeGameNamespace.Trader
{
    public interface ITraderDefinition
    {
        public string TraderName { get; }
        ITraderData Data { get; }
    }
}