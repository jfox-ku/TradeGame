namespace TradeGameNamespace.Random
{
    public interface IRandom
    {
        float Next();
        int NextInt(int minValue, int maxValue);
        int NextInt(int maxValue);
        float NextFloat(float minValue, float maxValue);
        float NextFloat(float maxValue);
    }
}