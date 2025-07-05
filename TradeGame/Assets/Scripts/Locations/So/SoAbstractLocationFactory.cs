using UnityEngine;

namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "Location", menuName = "Factories/Location/AbstractLocationFactory", order = 1)]
    public class SoAbstractLocationFactory : ScriptableObject, ILocationFactory
    {
        
        [SerializeField]
        private InterfaceReference<ILocationDefinitionFactory> locationDefinitionFactory;
        [SerializeField]
        private InterfaceReference<ILocationDataFactory> locationDataFactory;
        
        public ILocation Create() {
            return new Location(locationDefinitionFactory.Value.Create(), locationDataFactory.Value.Create());
        }
    }
}