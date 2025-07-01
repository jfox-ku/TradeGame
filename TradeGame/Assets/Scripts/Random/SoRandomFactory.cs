using UnityEngine;

namespace TradeGameNamespace.Random
{
    public class SoRandomFactory : ScriptableObject, IRandomFactory
    {
        [SerializeField]
        private int Seed;
        
        public IRandom Create() {
            return new Random(Seed);
        }
    }
}