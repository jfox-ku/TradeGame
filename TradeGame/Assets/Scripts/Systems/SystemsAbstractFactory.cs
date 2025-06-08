using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Systems
{
    public class SystemsAbstractFactory : ISystemsFactory
    {
        private List<ISystemFactory<ISystem>> _systemFactories;
        
        public SystemsAbstractFactory(List<ISystemFactory<ISystem>> systemFactories) {
            _systemFactories = systemFactories;
        }
        
        public List<ISystem> CreateSystems() {
            var systems = new List<ISystem>();
            foreach (var factory in _systemFactories) {
                systems.Add(factory.CreateSystem());
            }
            return systems;
        }
    }
}