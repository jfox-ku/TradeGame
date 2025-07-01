namespace TradeGameNamespace.Random
{
    public class Random : IRandom
    {
        private System.Random _random;
        public Random(int seed = 0)
        {
            _random = new System.Random(seed);
        }
        
        public float Next() {
            return (float)_random.NextDouble();
        }
        
        public int NextInt(int minValue, int maxValue) {
            return _random.Next(minValue, maxValue);
        }
        
        public int NextInt(int maxValue) {
            return _random.Next(maxValue);
        }
        
        public float NextFloat(float minValue, float maxValue) {
            return (float)_random.NextDouble() * (maxValue - minValue) + minValue;
        }
        
        public float NextFloat(float maxValue) {
            return (float) (_random.NextDouble() * maxValue);
        }
        
    }
}