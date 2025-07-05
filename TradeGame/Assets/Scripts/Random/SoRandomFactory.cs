using UnityEngine;

namespace TradeGameNamespace.Random
{
    [CreateAssetMenu(fileName = "Random", menuName = "Factories/RandomFactory")]
    public class SoRandomFactory : ScriptableObject, IRandomFactory
    {
        [SerializeField]
        private int Seed;
        
        public IRandom Create() {
            return new Random(Seed);
        }
    }
}