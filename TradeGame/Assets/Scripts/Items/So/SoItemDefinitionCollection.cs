using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "New ItemDefinitionCollection", menuName = "Collections/ItemDefinitionCollection")]
    public class SoItemDefinitionCollection : ScriptableObject, IItemDefinitionCollection
    {
        [SerializeField]
        private List<InterfaceReference<IItemDefinition>> ItemDefinitions;
        
        public IEnumerable<IItemDefinition> GetItems() {
            return ItemDefinitions.ConvertAll(item => item.Value);
        }
    }
}