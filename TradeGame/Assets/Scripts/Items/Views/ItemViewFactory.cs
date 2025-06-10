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

        public IItemView Create(IItem item, IItemViewData data) {
            var gameObj = new GameObject();
            var view = gameObj.AddComponent<ItemView>();
            view.AssignController(item);
            view.AssignData(data);
            return view;
        }
    }
}