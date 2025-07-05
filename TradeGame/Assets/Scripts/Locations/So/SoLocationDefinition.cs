using System;
using UnityEngine;

namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "New Location Definition", menuName = "Location/LocationDefinition")]
    public class SoLocationDefinition : ScriptableObject , ILocationDefinition
    {
        [SerializeField]
        private string _name;
        
        public string Name => _name;
        public int CompareTo(ILocationDefinition other) => String.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}