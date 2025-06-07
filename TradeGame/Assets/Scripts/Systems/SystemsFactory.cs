using System.Collections.Generic;

namespace DefaultNamespace.Systems
{
    public class SystemsFactory : ISystemsFactory
    {
        public List<ISystem> CreateSystems() {
            return new List<ISystem>() {
                
            };
        }
    }
}