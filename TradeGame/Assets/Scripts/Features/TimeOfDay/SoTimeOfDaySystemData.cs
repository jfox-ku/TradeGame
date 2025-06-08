
using System;
using UnityEngine;

namespace DefaultNamespace.Features.TimeOfDay
{
    [CreateAssetMenu(fileName = "TimeOfDaySystemData", menuName = "ScriptableObjects/Systems/TimeOfDay/TimeOfDaySystemData")]
    public class SoTimeOfDaySystemData :  ScriptableObject, ITimeOfDaySystemData
    {
        [SerializeField]
        private float dayDuration;
        
        [SerializeField]
        private AnimationCurve timeToLightIntensity;
        
        public float DayDuration => dayDuration;
        public Func<float, float> TimeToLightIntensity => (time) => timeToLightIntensity.Evaluate(time / dayDuration);
    }
}