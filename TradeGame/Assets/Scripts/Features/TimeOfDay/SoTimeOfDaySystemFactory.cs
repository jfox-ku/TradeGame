using TradeGameNamespace.Systems;
using UnityEngine;

namespace TradeGameNamespace.Features.TimeOfDay
{
    [CreateAssetMenu(fileName = "SoTimeOfDaySystemFactory", menuName = "Systems/Factories/TimeOfDaySystemFactory")]
    public class SoTimeOfDaySystemFactory : ScriptableObject, ISystemFactory<TimeOfDaySystem>
    {
        [SerializeField]
        private InterfaceReference<ITimeOfDaySystemData> _dataReference;
        
        public TimeOfDaySystem Create() {
            return new TimeOfDaySystem(_dataReference.Value);
        }
    }
}