using UnityEngine;

namespace TradeGameNamespace.Items
{
    public class MonoItemAbstractFactory : MonoBehaviour, IItemFactory
    {
        [SerializeField]
        private InterfaceReference<IItemDefinitionFactory> _itemDataFactory;
        [SerializeField]
        private InterfaceReference<IItemConditionsFactory> _conditionsFactory;
        
        public IItem CreateItem() {
            return new Item(_itemDataFactory.Value.Create(), _conditionsFactory.Value.Create());
        }
    }
}