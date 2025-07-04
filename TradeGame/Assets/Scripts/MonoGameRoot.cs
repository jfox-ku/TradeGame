using System;
using System.Collections;
using System.Collections.Generic;
using TradeGameNamespace;
using TradeGameNamespace.RuntimeState;
using TradeGameNamespace.Systems;
using UnityEngine;

public class MonoGameRoot : MonoBehaviour, IGameRoot
{
    public List<InterfaceReference<ISystemsFactory>> SystemsFactory;
    private List<ISystem> _systems = new List<ISystem>();
    private List<ITickSystem> _tickSystems = new List<ITickSystem>();
    public IRuntimeStateHandler RuntimeStateHandler { get; }
    
    void Start() {
        Initialize();
    }
    
    void Update() {
        Tick(Time.deltaTime);
    }

    private void OnDisable() {
        Shutdown();
    }
    
    public void Initialize() {
        _systems.Clear();
        
        AddRuntimeSystem();
        CreateSystemsFromFactories();
        CastTickSystems();
        InitializeSystems();
    }

    private void AddRuntimeSystem() {
        _systems.Add(new RuntimeStateSystem());
    }

    private void CreateSystemsFromFactories() {
        foreach (var systemFactoryReference in SystemsFactory) {
            var systems = systemFactoryReference.Value.CreateSystems();
            _systems.AddRange(systems);
        }
    }

    private void InitializeSystems() {
        foreach (var system in _systems) {
            system.Initialize(this);
        }
    }

    private void CastTickSystems() {
        foreach (var system in _systems) {
            if (system is ITickSystem tickSystem) {
                _tickSystems.Add(tickSystem);
            }
        }
    }

    public void Tick(float deltaTime) {
        foreach (var tickSystem in _tickSystems) {
            tickSystem.Tick(deltaTime);
        }
    }

    public void AddSystem(ISystem system) {
        throw new System.InvalidOperationException("MonoGameRoot does not support adding systems at runtime. Add them in the inspector.");
    }

    public ISystem GetSystem<T>() where T : ISystem {
        foreach (var system in _systems) {
            if (system is T castSystem) {
                return castSystem;
            }
        }
        return null;
    }
    
    public void StartGame() {
        
    }

    public void Shutdown() {
        _tickSystems.Clear();
    }

    
}
