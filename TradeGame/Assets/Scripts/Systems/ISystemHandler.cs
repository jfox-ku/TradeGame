namespace DefaultNamespace.Systems
{
    public interface ISystemHandler
    {
        void AddSystem(ISystem system);
        ISystem GetSystem<T>() where T : ISystem;
        void Tick(float deltaTime);
    }
}