using System.Collections.Generic;
using TradeGameNamespace.Items.Views;
using TradeGameNamespace.Views;
using UnityEngine;

namespace TradeGameNamespace.Inventory.Views
{
    public class InventoryView : ClearableView<IInventory,IInventoryViewData>
    {
        [SerializeField]
        private List<ItemView> itemViews;
        
        protected override void OnControllerAssigned() {
            
        }

        protected override void OnDataAssigned() {
            
        }

        protected override void OnClear() {
            foreach (var itemView in itemViews) {
                itemView.Clear();
            }
        }
    }
}