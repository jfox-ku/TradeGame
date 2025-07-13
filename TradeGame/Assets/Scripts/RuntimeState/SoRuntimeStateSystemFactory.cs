using System;
using TradeGameNamespace.Systems;
using UnityEngine;

namespace TradeGameNamespace.RuntimeState
{
    [CreateAssetMenu(fileName = "SoRuntimeStateSystemFactory", menuName = "Systems/Factory/RuntimeStateSystemFactory")]
    public class SoRuntimeStateSystemFactory : ScriptableObject, ISystemFactory<RuntimeStateSystem>
    {
        public RuntimeStateSystem Create() {
            return new RuntimeStateSystem();
        }
    }
}