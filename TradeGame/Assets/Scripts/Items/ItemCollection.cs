using System.Collections;
using System.Collections.Generic;

namespace TradeGameNamespace.Items
{
    public class ItemCollection : IItemCollection
    {
        private readonly List<IItem> _items;
        
        public ItemCollection(List<IItem> items) {
            _items = items;
        }
        
        public IEnumerator<IItem> GetEnumerator() {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public int Count => _items.Count;

        public IItem this[int index] => _items[index];
    }
}