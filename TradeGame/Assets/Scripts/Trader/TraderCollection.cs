using System.Collections;
using System.Collections.Generic;
using TradeGameNamespace.Trader;

namespace Trader
{
    public class TraderCollection : ITraderCollection
    {
        private readonly List<ITrader> _traders;
        
        public TraderCollection(List<ITrader> traders) {
            _traders = traders;
        }
        
        public TraderCollection() : this(new List<ITrader>()) {
        }
        
        public IEnumerator<ITrader> GetEnumerator() {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public int Count => _traders.Count;

        public ITrader this[int index] => _traders[index];
    }
}