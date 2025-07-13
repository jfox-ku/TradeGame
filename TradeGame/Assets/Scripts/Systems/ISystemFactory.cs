namespace TradeGameNamespace.Systems
{
    public interface ISystemFactory<out TSystem> : IFactory<TSystem> where TSystem : ISystem
    {
        
    }
}