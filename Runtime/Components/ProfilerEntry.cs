using Unity.Profiling;
using UnityEngine.Profiling;

namespace GGUnityProfiler
{
    public class ProfilerEntry
    {
        #region Variables

        public ProfilerMarker Marker { get; }
        public Sampler Sampler { get; }
        public string ProfileName { get; }

        #endregion Variables


        #region Construction

        public ProfilerEntry(string markerName)
        {
            ProfileName = markerName;
            Marker = new ProfilerMarker(markerName);
            Sampler = Sampler.Get(ProfileName);
        }

        #endregion Construction


        #region Use

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ProfilerMarker.AutoScope RecordInScope()
        {
            return Marker.Auto();
        }

        #endregion Use
    }
}
