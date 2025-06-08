using UnityEngine;

namespace TradeGameNamespace.Items.ItemCategories
{
    public abstract class SoItemCategory<T> : ScriptableObject, IItemCategory where T : IItemCategory, new()
    {
        T itemCategory;

        public string Name {
            get {
                itemCategory ??= new T();
                return itemCategory.Name;
            }
        }
    }
}