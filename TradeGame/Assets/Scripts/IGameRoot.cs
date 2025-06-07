using DefaultNamespace.Systems;

namespace DefaultNamespace
{
    public interface IGameRoot : ISystemHandler
    {
        void Initialize();
        void StartGame();
        void Shutdown();
    }
}