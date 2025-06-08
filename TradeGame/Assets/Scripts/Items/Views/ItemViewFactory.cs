using TradeGameNamespace.Views;
using UnityEngine;

namespace TradeGameNamespace.Items.Views
{
    public class ItemViewFactory : IItemViewFactory
    {
        public IItemView Create() {
            var obj = new GameObject();
            var view = obj.AddComponent<ItemView>();
            return view;
        }
    }
}