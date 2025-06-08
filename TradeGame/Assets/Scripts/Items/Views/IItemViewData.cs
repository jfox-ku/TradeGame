using TradeGameNamespace.Views;
using UnityEngine;

namespace TradeGameNamespace.Items.Views
{
    public interface IItemViewData : IViewData
    {
        Sprite Icon { get; }
    }
}