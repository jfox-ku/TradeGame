namespace TradeGameNamespace.Systems
{
    public interface ISystemHandler
    {
        void AddSystem(ISystem system);
        T GetSystem<T>() where T : ISystem;
        void Tick(float deltaTime);
    }
}