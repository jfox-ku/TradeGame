namespace DefaultNamespace.Systems
{
    public interface ISystemFactory<out TSystem> where TSystem : ISystem
    {
        TSystem CreateSystem();
    }
}