using UnityEngine;

namespace TradeGameNamespace.Locations
{
    [CreateAssetMenu(fileName = "SavedLocationFactory", menuName = "Location/SavedLocationFactory")]
    public class SoSavedLocationFactory : ScriptableObject, ILocationFactory
    {
        [SerializeField]
        private string saveName;
        
        private SavedLocationFactory _savedLocationFactory;
        
        public ILocation Create() {
            _savedLocationFactory ??= new SavedLocationFactory(saveName);
            return _savedLocationFactory.Create();
        }
    }
}