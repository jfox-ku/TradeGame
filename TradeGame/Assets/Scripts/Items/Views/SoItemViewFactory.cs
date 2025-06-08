using System.IO;
using UnityEngine;

namespace TradeGameNamespace.Items.Views
{
    [CreateAssetMenu(fileName = "ItemViewFactory", menuName = "Views/Factories/ItemViewFactory")]
    public class SoItemViewFactory : ScriptableObject, IItemViewFactory
    {
        [SerializeField]
        private InterfaceReference<IItemView> _itemPrefab;
        
        public IItemView Create() {
            if(_itemPrefab.Value is MonoBehaviour itemViewPrefab)
            {
                var prefab = Instantiate(itemViewPrefab);
                var itemView = prefab.GetComponent<IItemView>();
                return itemView;
            }

            throw new InvalidDataException("Item prefab must be a MonoBehaviour that implements IItemView interface.");
        }
    }
}