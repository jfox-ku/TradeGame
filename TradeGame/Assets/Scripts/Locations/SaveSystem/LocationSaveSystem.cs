using TradeGameNamespace.Systems;
using UnityEngine;

namespace TradeGameNamespace.Locations.SaveSystem
{
    public class LocationSaveSystem : ISystem
    {
        public void Initialize(ISystemHandler systemHandler) { }

        public void Save(string name, ILocationData locationData) {
            var json = JsonUtility.ToJson(locationData);
            FileManager.WriteToFile(name, json);
        }

        public Location Load(string name) {
            FileManager.LoadFromFile(name, out var json);
            var Location = JsonUtility.FromJson<Location>(json);
            if (Location != null) return Location;
            Debug.LogWarning($"No saved location found for {name}. Creating a new one.");
            return new Location(ILocationDefinition.Default, ILocationData.Default);
        }
    }
}