using System.Collections.Generic;
using TradeGameNamespace.RuntimeState;
using TradeGameNamespace.Systems;

namespace TradeGameNamespace
{
    public class GameRoot : IGameRoot
    {
        public IRuntimeStateHandlerSystem RuntimeStateHandlerSystem { get; private set; }
        
        private readonly List<ISystem> _systems = new List<ISystem>();
        private readonly List<ITickSystem> _tickSystems = new List<ITickSystem>();
        
        
        public GameRoot() {}
        public GameRoot(List<ISystem> systems) {
            _systems = systems;
        }
        
        
        public void Initialize() {
            foreach (var system in _systems) {
                if(system is IRuntimeStateHandlerSystem runtimeStateHandlerSystem) {
                    RuntimeStateHandlerSystem = runtimeStateHandlerSystem;
                }
                
                if (system is ITickSystem tickSystem) {
                    _tickSystems.Add(tickSystem);
                }
            }
            
            foreach (var system in _systems) {
                system.Initialize(this);
            }
        }

        public void StartGame() {
            
        }

        public void Shutdown() {
            
        }
        
        public void AddSystem(ISystem system) {
            if (_systems.Contains(system)) {
                throw new System.ArgumentException("System already exists in the game root.");
            }
            _systems.Add(system);
        }

        public T GetSystem<T>() where T : ISystem {
            foreach (var system in _systems) {
                if (system is T castSystem) {
                    return castSystem;
                }
            }
            return default;
        }

        public void Tick(float deltaTime) {
            foreach (var tickSystem in _tickSystems) {
                tickSystem.Tick(deltaTime);
            }
        }
    }
}