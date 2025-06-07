namespace DefaultNamespace.Systems
{
    public interface ITickSystem : ISystem
    {
        void Tick(float deltaTime);
    }
}