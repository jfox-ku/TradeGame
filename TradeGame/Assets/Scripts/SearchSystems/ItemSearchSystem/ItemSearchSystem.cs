using System;
using TradeGameNamespace.Items;
using TradeGameNamespace.Random;
using TradeGameNamespace.RuntimeState;

namespace TradeGameNamespace.SearchSystems.ItemSearchSystem
{
    public class ItemSearchSystem : SearchSystem<IItem>
    {
        private IItemFactory _itemFactory;
        
        public ItemSearchSystem(ISearchSystemData data, IItemFactory itemFactory ,IRandom random = null) : base(data, random) {
            _itemFactory = itemFactory;
        }

        protected override IItem CreateSearchResult() {
            return _itemFactory.CreateItem();
        }
    }
}