using System.Collections.Generic;
using DefaultNamespace.Items.ItemCategories;
using UnityEngine;

namespace DefaultNamespace.Items
{
    [CreateAssetMenu(fileName = "NewItemDataFactory", menuName = "ItemDataFactory")]
    public class SoItemDataFactory : ScriptableObject, IItemDataFactory
    {
        public string Name;
        public float BaseValue;
        public float Weight;
        public string Description;
        public List<InterfaceReference<IItemCategory>> Categories;
        
        private List<IItemCategory> CategoriesInternal => Categories.ConvertAll<IItemCategory>(category => category.Value);
        
        public IItemData CreateItemData() {
            return new ItemData(
                Name,
                BaseValue,
                Weight,
                Description,
                CategoriesInternal
            );
        }
    }
}