using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Systems;
using UnityEngine;

public class MonoGameRoot : MonoBehaviour, IGameRoot
{
    public List<InterfaceReference<ISystem>> Systems;
    
    private bool _initialized = false;
    private List<ITickSystem> _tickSystems = new List<ITickSystem>();
    
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update() {
        Tick(Time.deltaTime);
    }

    private void OnDisable() {
        Shutdown();
    }

    public void AddSystem(ISystem system) {
        throw new System.InvalidOperationException("MonoGameRoot does not support adding systems at runtime. Add them in the inspector.");
    }

    public ISystem GetSystem<T>() where T : ISystem {
        foreach (var systemInterfaceReference in Systems) {
            if (systemInterfaceReference.Value is T system) {
                return system;
            }
        }
        return null;
    }

    public void Tick(float deltaTime) {
        foreach (var tickSystem in _tickSystems) {
            tickSystem.Tick(deltaTime);
        }
    }

    public void Initialize() {
        foreach (var systemInterfaceReference in Systems) {
            if (systemInterfaceReference.Value is ITickSystem tickSystem) {
                _tickSystems.Add(tickSystem);
            }
        }
        
        foreach (var systemInterfaceReference in Systems) {
            systemInterfaceReference.Value.Initialize();
        }
        
        _initialized = true;
    }

    public void StartGame() {
        
    }

    public void Shutdown() {
        _tickSystems.Clear();
    }
}
