using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    public class SoTraderDefinitionCollection : ScriptableObject, IReadOnlyList<ITraderDefinition>
    {
        [SerializeField]
        private List<InterfaceReference<ITraderDefinition>> traderDefinitions = new List<InterfaceReference<ITraderDefinition>>();
        private List<ITraderDefinition> _traderDefinitions;
        
        private List<ITraderDefinition> TraderDefinitions {
            get {
                if (_traderDefinitions != null) return _traderDefinitions;
                _traderDefinitions = new List<ITraderDefinition>();
                foreach (var trader in traderDefinitions) {
                    _traderDefinitions.Add(trader.Value);
                }
                return _traderDefinitions;
            }
        }
        
        public IEnumerator<ITraderDefinition> GetEnumerator() {
            return TraderDefinitions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        
        public int Count => TraderDefinitions.Count;

        public ITraderDefinition this[int index] => TraderDefinitions[index];
    }
}