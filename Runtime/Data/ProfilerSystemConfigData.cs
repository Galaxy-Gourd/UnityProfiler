using GGUnityData;
using UnityEngine;

namespace GGUnityProfiler.Data
{
    [CreateAssetMenu(
        fileName = "Profiler System Configuration Data", 
        menuName = "Configuration Data/Systems/Profiler System Data", 
        order = 0)]
    public class ProfilerSystemConfigData : UnityConfigurationData
    {
        [Header("Data")]
        [Tooltip("Check to completely disable runtime profiling of systems")]
        public bool DisableRuntimeProfiling;
    }
}