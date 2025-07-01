using System;
using TradeGameNamespace.Systems;

namespace TradeGameNamespace.SearchSystems
{
    public interface ISearchSystem<out T> : ITickSystem
    {
        event Action<T> OnSearchResultFound;
        void StartSearch();
    }
}