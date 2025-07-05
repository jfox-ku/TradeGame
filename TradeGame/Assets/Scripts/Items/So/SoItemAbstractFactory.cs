using UnityEngine;
using UnityEngine.Serialization;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "ItemAbstractFactory", menuName = "Factories/Item/ItemAbstractFactory", order = 0)]
    public class SoItemAbstractFactory : ScriptableObject, IItemFactory
    {
        private ItemAbstractFactory _internalFactory;

        [FormerlySerializedAs("ItemDataFactory")]
        [SerializeField]
        private InterfaceReference<IItemDefinitionFactory> ItemDefinitionFactory;
        [SerializeField]
        private InterfaceReference<IItemConditionsFactory> ItemConditionsFactory;
        
        public IItem CreateItem() {
            _internalFactory ??= new ItemAbstractFactory(ItemDefinitionFactory.Value, ItemConditionsFactory.Value);
            return _internalFactory.CreateItem();
        }
    }
}