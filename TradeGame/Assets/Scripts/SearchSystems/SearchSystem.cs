using System;
using TradeGameNamespace.Random;
using TradeGameNamespace.Systems;

namespace TradeGameNamespace.SearchSystems
{
    public abstract class SearchSystem<T> : ISearchSystem<T>   {
        
        public event Action<T> OnSearchResultFound;
        
        protected readonly IRandom _random;
        protected readonly ISearchSystemData _data;
        protected float _searchDuration;
        protected float _searchTargetDuration;
        
        private bool _isSearching;
        
        public SearchSystem(ISearchSystemData data, IRandom random = null) {
            _random = random ?? new Random.Random();
            _isSearching = false;
            _data = data;
        }
        
        public void Initialize(ISystemHandler systemHandler) {
            
        }

        public void Tick(float deltaTime) {
            Search(deltaTime);
        }

       
        public void StartSearch() {
            _searchDuration = 0;
            _searchTargetDuration = _random.NextFloat(_data.SearchDurationMin, _data.SearchDurationMax);
            _isSearching = true;
        }

        private void Search(float deltaTime) {
            if (!_isSearching) return;
            _searchDuration += deltaTime;
            if (_searchDuration >= _searchTargetDuration) {
                _isSearching = false;
                var result = CreateSearchResult();
                OnSearchResultFound?.Invoke(result);
            }
        }

        protected abstract T CreateSearchResult();
    }
}