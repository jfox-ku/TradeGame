using System.Collections.Generic;
using TradeGameNamespace;
using TradeGameNamespace.Locations.SaveSystem;
using TradeGameNamespace.RuntimeState;
using TradeGameNamespace.Systems;
using UnityEngine;

public class MonoGameRoot : MonoBehaviour, IGameRoot
{
    public List<InterfaceReference<ISystemsFactory>> SystemsFactory;
    
    private List<ISystem> _systemsFromFactories = new List<ISystem>();
    
    private IGameRoot _gameRoot;
    public IRuntimeStateHandlerSystem RuntimeStateHandlerSystem => _gameRoot.RuntimeStateHandlerSystem;
    
    void Start() {
        CreateMandatorySystems();
        CreateSystemsFromFactories();
        Initialize();
    }
    
    void Update() {
        Tick(Time.deltaTime);
    }

    private void OnDisable() {
        Shutdown();
    }
    
    public void Initialize() {
        _gameRoot = new GameRoot(_systemsFromFactories);
        _gameRoot.Initialize();
    }

    private void CreateMandatorySystems() {
        _systemsFromFactories.Add(new RuntimeStateSystem());
        _systemsFromFactories.Add(new LocationSaveSystem());
    }

    private void CreateSystemsFromFactories() {
        foreach (var systemFactoryReference in SystemsFactory) {
            var systems = systemFactoryReference.Value.CreateSystems();
            _systemsFromFactories.AddRange(systems);
        }
    }

    public void Tick(float deltaTime) {
       _gameRoot.Tick(deltaTime);
    }

    public void AddSystem(ISystem system) {
        _gameRoot.AddSystem(system);
    }

    public T GetSystem<T>() where T : ISystem {
        return _gameRoot.GetSystem<T>();
    }
    
    public void StartGame() {
        
    }

    public void Shutdown() {
        _gameRoot = null;
    }

    
}
