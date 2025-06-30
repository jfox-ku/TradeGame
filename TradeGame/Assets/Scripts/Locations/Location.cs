namespace TradeGameNamespace.Locations
{
    public class Location : ILocation
    {
        public Location(ILocationDefinition definition, ILocationData data) {
            Definition = definition;
            Data = data;
        }

        public ILocationDefinition Definition { get; }
        public ILocationData Data { get; }
        
        public int CompareTo(ILocation other) => Definition.CompareTo(other.Definition);
    }
}