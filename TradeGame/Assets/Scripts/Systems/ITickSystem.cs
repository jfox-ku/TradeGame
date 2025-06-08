namespace TradeGameNamespace.Systems
{
    public interface ITickSystem : ISystem
    {
        void Tick(float deltaTime);
    }
}