using System;

namespace TradeGameNamespace.Locations
{
    public interface ILocationDefinition : IComparable<ILocationDefinition>
    {
        string Name { get; }

        static ILocationDefinition Default => new LocationDefinition();
    }
}