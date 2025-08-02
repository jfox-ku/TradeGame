using Trader;
using UnityEngine;

namespace TradeGameNamespace.Trader.So
{
    [CreateAssetMenu(fileName = "PlayerTraderDataFactory", menuName = "Player/PlayerTraderDataFactory")]
    public class SoPlayerTraderDataFactory : ScriptableObject, ITraderDataFactory
    {
        public ITraderData Create() {
            return TraderData.CreatePlayerTraderData();
        }
    }
}