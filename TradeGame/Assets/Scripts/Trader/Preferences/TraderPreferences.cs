using System.Collections;
using System.Collections.Generic;

namespace TradeGameNamespace.Trader
{
    public class TraderPreferences<T> : ITraderPreferences<T> where T : ITraderPreferenceType
    {
        private Dictionary<T, float> Preferences { get; }
        
        public TraderPreferences() {
            Preferences = new Dictionary<T, float>();
        }
        
        
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
            return Preferences[type];
        }
    }
}