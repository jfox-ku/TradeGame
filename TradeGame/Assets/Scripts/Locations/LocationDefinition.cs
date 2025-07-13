using System;

namespace TradeGameNamespace.Locations
{
    public class LocationDefinition : ILocationDefinition
    {
        public string Name { get; }
        
        public LocationDefinition(string name = "Home") {
            Name = name;
        }
        
        public int CompareTo(ILocationDefinition other) {
            return string.Compare(other.Name, Name, StringComparison.Ordinal);
        }
    }
}