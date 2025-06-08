using TradeGameNamespace.Inventory;
using TradeGameNamespace.Trader;

namespace TradeGameNamespace.Features.TradeSystem
{
    public class TradeOffer
    {
        IInventory OfferInventory;
        IInventory AskInventory;
        private ITrader OfferTrader;
        private ITrader AskTrader;
        
        public TradeOffer(ITrader offerTrader, ITrader askTrader) {
            OfferTrader = offerTrader;
            AskTrader = askTrader;
            OfferInventory = offerTrader.InTradeInventory;
            AskInventory = askTrader.InTradeInventory;
        }
        
        
    }
}