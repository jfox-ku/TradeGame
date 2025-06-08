using DefaultNamespace.Systems;
using UnityEngine;

namespace DefaultNamespace.Features.TimeOfDay
{
    [CreateAssetMenu(fileName = "SoTimeOfDaySystemFactory", menuName = "ScriptableObjects/Systems/TimeOfDay/TimeOfDaySystemFactory")]
    public class SoTimeOfDaySystemFactory : ScriptableObject, ISystemFactory<TimeOfDaySystem>
    {
        [SerializeField]
        private InterfaceReference<ITimeOfDaySystemData> _dataReference;
        
        public TimeOfDaySystem CreateSystem() {
            return new TimeOfDaySystem(_dataReference.Value);
        }
    }
}