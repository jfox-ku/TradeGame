using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "ItemAbstractFactory", menuName = "ItemAbstractFactory", order = 0)]
    public class SoItemAbstractFactory : ScriptableObject, IItemFactory
    {
        private ItemAbstractFactory _internalFactory;

        [SerializeField]
        private InterfaceReference<IItemDataFactory> ItemDataFactory;
        [SerializeField]
        private InterfaceReference<IItemConditionsFactory> ItemConditionsFactory;
        
        public IItem CreateItem() {
            _internalFactory ??= new ItemAbstractFactory(ItemDataFactory.Value, ItemConditionsFactory.Value);
            return _internalFactory.CreateItem();
        }
    }
}