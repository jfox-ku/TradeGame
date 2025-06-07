using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Systems;
using UnityEngine;

public class GameRoot : MonoBehaviour, IGameRoot
{
    private bool _initialized = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSystem(ISystem system) {
        throw new System.NotImplementedException();
    }

    public ISystem GetSystem<T>() where T : ISystem {
        throw new System.NotImplementedException();
    }

    public void Tick(float deltaTime) {
        throw new System.NotImplementedException();
    }

    public void Initialize() {
        throw new System.NotImplementedException();
    }

    public void StartGame() {
        throw new System.NotImplementedException();
    }

    public void Shutdown() {
        throw new System.NotImplementedException();
    }
}
