using UnityEngine;

namespace TradeGameNamespace.Random
{
    [CreateAssetMenu(menuName = "Random")]
    public class SoRandom : ScriptableObject, IRandom
    {
        [SerializeField]
        private int seed = 0;
        
        private Random _random;
        private Random Random => _random ??= new Random(seed);

        public float Next() {
            return Random.Next();
        }

        public int NextInt(int minValue, int maxValue) {
            return Random.NextInt(minValue, maxValue);
        }

        public int NextInt(int maxValue) {
            return Random.NextInt(maxValue);
        }

        public float NextFloat(float minValue, float maxValue) {
            return Random.NextFloat(minValue, maxValue);
        }

        public float NextFloat(float maxValue) {
            return Random.NextFloat(maxValue);
        }
    }
}