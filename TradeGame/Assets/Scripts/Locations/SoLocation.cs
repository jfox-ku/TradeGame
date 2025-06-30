using UnityEngine;

namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "Location", menuName = "Location")]
    public class SoLocation : ScriptableObject, ILocation
    {
        public ILocationDefinition Definition => locationDefinition.Value;
        public ILocationData Data => locationData.Value;
        public int CompareTo(ILocation other) => other.Definition.CompareTo(Definition);
        
        [SerializeField]
        private InterfaceReference<ILocationDefinition> locationDefinition;
        [SerializeField]
        private InterfaceReference<ILocationData> locationData;
    }
}