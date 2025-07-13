using UnityEngine;

namespace TradeGameNamespace.Locations
{
    public class SavedLocationFactory : IFactory<ILocation>
    {
        public string SaveName { get; }
        
        public SavedLocationFactory(string saveName) {
            SaveName = saveName;
        }
        
        public ILocation Create() {
            FileManager.LoadFromFile(SaveName, out var json);
            var savedLocation = JsonUtility.FromJson<Location>(json);
            if (savedLocation == null)
            {
                Debug.LogWarning($"No saved location found for {SaveName}. Creating a new one.");
                return new Location(ILocationDefinition.Default, ILocationData.Default);
            }

            return savedLocation;
        }
    }
}