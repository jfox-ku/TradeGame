using System.Collections;
using System.Collections.Generic;
using TradeGameNamespace.Trader.So;
using UnityEngine;

namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "New Location", menuName = "Location/LocationCollection")]
    public class SoLocationCollection : ScriptableObject, IReadOnlyList<ILocation>
    {
        [SerializeField]
        public List<InterfaceReference<ILocation>> LocationReferences;
        
        private List<ILocation> _locations;
        public List<ILocation> Locations {
            get {
                if (_locations != null) return _locations;
                _locations = new List<ILocation>();
                foreach (var locationReference in LocationReferences) {
                    _locations.Add(locationReference.Value);
                }
                return _locations;
            }
        }
        
        public IEnumerator<ILocation> GetEnumerator() {
            return Locations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public int Count => Locations.Count;

        public ILocation this[int index] => Locations[index];
    }
}