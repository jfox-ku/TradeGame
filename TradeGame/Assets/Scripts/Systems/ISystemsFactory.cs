using System.Collections.Generic;

namespace TradeGameNamespace.Systems
{
    public interface ISystemsFactory
    {
        List<ISystem> CreateSystems();
    }
}