using System.Collections.Generic;

namespace DefaultNamespace.Systems
{
    public interface ISystemsFactory
    {
        List<ISystem> CreateSystems();
    }
}