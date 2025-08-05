using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TradeGameNamespace.Items
{
    [CreateAssetMenu(fileName = "SoItemCollection", menuName = "Items/ItemCollection")]
    public class SoItemCollection : ScriptableObject, IItemCollection
    {
        public IEnumerator<IItem> GetEnumerator() {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public int Count { get; }

        public IItem this[int index] => throw new System.NotImplementedException();
    }
}