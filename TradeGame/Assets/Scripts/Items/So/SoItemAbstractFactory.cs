using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "ItemAbstractFactory", menuName = "Factories/Item/ItemAbstractFactory", order = 0)]
    public class SoItemAbstractFactory : ScriptableObject, IItemFactory
    {
        private ItemAbstractFactory _internalFactory;
        
        [SerializeField]
        private InterfaceReference<IItemDefinitionFactory> ItemDefinitionFactory;
        
        
        public IItem Create() {
            _internalFactory ??= new ItemAbstractFactory(ItemDefinitionFactory.Value);
            return _internalFactory.Create();
        }
    }
}