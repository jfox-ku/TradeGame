using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    public abstract class SoTraderPreferences<TPreferenceType, TData> : ScriptableObject, ITraderPreferences<TPreferenceType> 
        where TPreferenceType : class, ITraderPreferenceType
        where TData : TraderPreferenceData<TPreferenceType>
    {
        [SerializeField]
        private List<TData> _preferencesData = new List<TData>();
        private TraderPreferences<TPreferenceType> _internalPreferences;
        
        private TraderPreferences<TPreferenceType> InternalPreferences {
            get {
                if (_internalPreferences == null) {
                    _internalPreferences = new TraderPreferences<TPreferenceType>();
                    foreach (var data in _preferencesData) {
                        _internalPreferences.SetPreferenceStrength(data.Preference, data.Strength);
                    }
                }
                return _internalPreferences;
            }
        }

        public IEnumerator<TPreferenceType> GetEnumerator() {
            return InternalPreferences.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public bool HasPreference(TPreferenceType type) {
            return InternalPreferences.HasPreference(type);
        }

        public float GetPreferenceStrength(TPreferenceType type) {
            return InternalPreferences.GetPreferenceStrength(type);
        }

        public void SetPreferenceStrength(TPreferenceType type, float strength) {
            InternalPreferences.SetPreferenceStrength(type, strength);
        }
    }
    
    [Serializable]
    public abstract class TraderPreferenceData<T> where T : class, ITraderPreferenceType
    {
        [SerializeField]
        public InterfaceReference<T> Preference;
        [SerializeField]
        public float Strength;
    }
}