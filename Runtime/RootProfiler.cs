using GGSharpTelemetry;
using GGUnityTick;

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
    }
}