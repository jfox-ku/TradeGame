using TradeGameNamespace.RuntimeState;
using TradeGameNamespace.Systems;

namespace TradeGameNamespace
{
    public interface IGameRoot : ISystemHandler
    {
        void Initialize();
        void StartGame();
        void Shutdown();
        IRuntimeStateHandler RuntimeStateHandler { get; }
    }
}