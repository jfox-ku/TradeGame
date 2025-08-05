using System.Collections;
using System.Collections.Generic;

namespace TradeGameNamespace.Trader
{
    public class TraderPreferences<T> : ITraderPreferences<T> where T : ITraderPreferenceType
    {
        public const float DefaultPreferenceStrength = 0f;
        
        private Dictionary<T, float> Preferences { get; } = new();

        public IEnumerator<T> GetEnumerator() {
           return Preferences.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public bool HasPreference(T type) {
            return Preferences.ContainsKey(type);
        }

        public float GetPreferenceStrength(T type) {
            return Preferences.GetValueOrDefault(type, DefaultPreferenceStrength);
        }

        public void SetPreferenceStrength(T type, float strength) {
            Preferences[type] = strength;
        }
    }
}