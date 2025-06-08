using TradeGameNamespace.Views;
using UnityEngine;

namespace TradeGameNamespace.Items.Views
{
    public class ItemView : ClearableView<IItem,IItemViewData>, IItemView
    {
        [SerializeField]
        private SpriteRenderer spriteRenderer;

        protected override void OnControllerAssigned() {
            
        }

        protected override void OnDataAssigned() {
            spriteRenderer.sprite = _data.Icon;
        }

        protected override void OnClear() {
            spriteRenderer.sprite = null;
        }
    }
}