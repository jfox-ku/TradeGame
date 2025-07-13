using System.Collections.Generic;
using TradeGameNamespace.Random;
using TradeGameNamespace.Trader;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "ItemFactoryTraderParameter", menuName = "Factories/Item/ItemFactoryTraderParameter")]
    public class SoItemFactoryTraderParameter : ScriptableObject, IParameterizedFactory<ITrader, IItem>
    {
        [SerializeField]
        private InterfaceReference<IItemDefinitionCollection> _itemDefinitionCollection;
        [SerializeField]
        private InterfaceReference<IRandomFactory> _randomFactory;
        
        private IRandom _random;
        private List<IItemDefinition> _itemDefinitions;

        protected IRandom Random => _random ??= _randomFactory.Value.Create();
        protected List<IItemDefinition> ItemDefinitions => _itemDefinitions ??=  new List<IItemDefinition>(_itemDefinitionCollection.Value);

        public IItem CreateInventoryForTrader(ITrader parameter) {
            var itemDefinition = GetDefinitionForTrader(parameter);
            return new Item(itemDefinition);
        }

        protected virtual IItemDefinition GetDefinitionForTrader(ITrader trader) {
            var index = Random.NextInt(0, ItemDefinitions.Count);
            return ItemDefinitions[index];
        }

    }
}