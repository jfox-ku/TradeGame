using System.Collections.Generic;
using TradeGameNamespace.Items.ItemCategories;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "NewItemDefinitionFactory", menuName = "Item/ItemDefinitionFactory")]
    public class SoItemDefinitionFactory : ScriptableObject, IItemDefinitionFactory
    {
        public string Name;
        public float BaseValue;
        public float Weight;
        public string Description;
        public List<InterfaceReference<IItemCategory>> Categories;
        
        private List<IItemCategory> CategoriesInternal => Categories.ConvertAll<IItemCategory>(category => category.Value);
        
        public IItemDefinition Create() {
            return new ItemDefinition(
                Name,
                BaseValue,
                Weight,
                Description,
                CategoriesInternal
            );
        }
    }
}