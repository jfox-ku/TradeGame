using TradeGameNamespace.Items;
using TradeGameNamespace.Random;
using TradeGameNamespace.Systems;
using UnityEngine;

namespace TradeGameNamespace.SearchSystems.ItemSearchSystem
{
    [CreateAssetMenu(fileName = "ItemSearchSystemFactory", menuName = "Systems/Factory/ItemSearchSystemFactory")]
    public class SoItemSearchSystemFactory : ScriptableObject, ISystemFactory<ItemSearchSystem>
    {
        [SerializeField]
        private InterfaceReference<IRandomFactory> RandomFactory;
        private InterfaceReference<IItemFactory> ItemFactory;
        private InterfaceReference<ISearchSystemData> SearchSystemData;
        
        
        public ItemSearchSystem Create() {
            return new ItemSearchSystem(SearchSystemData.Value, ItemFactory.Value, RandomFactory.Value.Create());
        }
    }
}
