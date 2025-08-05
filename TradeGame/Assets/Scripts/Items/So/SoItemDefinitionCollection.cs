using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "ItemDefinitionCollection", menuName = "Items/ItemDefinitionCollection")]
    public class SoItemDefinitionCollection : ScriptableObject, IItemDefinitionCollection
    {
        [SerializeField]
        private List<InterfaceReference<IItemDefinition>> itemDefinitions;
        private List<IItemDefinition> _itemDefinitions;
        
        public List<IItemDefinition> ItemDefinitions{
            get {
                if (_itemDefinitions != null) return _itemDefinitions;
                _itemDefinitions = new List<IItemDefinition>();
                foreach (var itemDefinition in itemDefinitions) {
                    _itemDefinitions.Add(itemDefinition.Value);
                }
                return _itemDefinitions;
            }
        }

        public IEnumerator<IItemDefinition> GetEnumerator() {
            return ItemDefinitions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public int Count => ItemDefinitions.Count;

        public IItemDefinition this[int index] => ItemDefinitions[index];
    }
}