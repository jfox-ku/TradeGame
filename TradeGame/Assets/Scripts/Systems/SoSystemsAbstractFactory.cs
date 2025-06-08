using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Systems
{
    [CreateAssetMenu(fileName = "SoSystemsAbstractFactory", menuName = "Systems/SoSystemsAbstractFactory")]
    public class SoSystemsAbstractFactory : ScriptableObject, ISystemsFactory
    {
        [SerializeField]
        private List<InterfaceReference<ISystemFactory<ISystem>>> _systemFactoriesReferences;
        
        public List<ISystem> CreateSystems() {
            var systemFactories = _systemFactoriesReferences.ConvertAll(factoryRef => factoryRef.Value);
            var abstractFactory = new SystemsAbstractFactory(systemFactories);
            return abstractFactory.CreateSystems();
        }
    }
}