using GGSharpTelemetry;
using GGUnityTick;
using UnityEngine;

namespace GGUnityProfiler
{
    public static class RootProfiler
    {
        #region Variables

        public static ProfilerSystem Profiler;

        private static TelemetryTick _telemetryTick;

        #endregion Variables

        public static void OnTickSystemReady()
        {
            _telemetryTick = new TelemetryTick(RootTick.Tick);
        }
        
        
        #region Reset

        /// <summary>
        /// Resets static values to prevent issues related to domain reloading
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        public static void Reset()
        {
            _telemetryTick = null;
            Profiler = null;
        }

        #endregion Reset
    }
}