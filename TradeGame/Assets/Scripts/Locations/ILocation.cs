using System;

namespace TradeGameNamespace.Locations
{
    public interface ILocation : IComparable<ILocation>
    {
        ILocationDefinition Definition { get; }
        ILocationData Data { get; }
    }
}