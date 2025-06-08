using System.Collections.Generic;

namespace TradeGameNamespace.Systems
{
    public class SystemsFactory : ISystemsFactory
    {
        public List<ISystem> CreateSystems() {
            return new List<ISystem>() {
                
            };
        }
    }
}