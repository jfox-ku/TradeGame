namespace DefaultNamespace.Trader
{
    public interface ITraderPreference<out T> where T : ITraderPreferenceType
    {
        T PreferenceType { get; }
       ITraderPreferenceData Data { get; }
        
    }
}