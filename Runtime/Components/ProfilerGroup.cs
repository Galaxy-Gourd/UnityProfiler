using System.Collections.Generic;
using GGUnityData;
using GGUnityProfiler.Data;

namespace GGUnityProfiler
{
    public class ProfilerGroup : IUnitySystemComponent
    {
        #region Variables

        public readonly List<ProfilerEntry> _entries = new List<ProfilerEntry>();

        #endregion Variables


        #region Construction

        public ProfilerGroup()
        {
            RootProfiler.Profiler?.AddComponent(this);
        }

        #endregion Construction
        

        #region Registration

        public void RegisterEntry(ProfilerEntry entry)
        {
            _entries.Add(entry);
        }

        public void RemoveEntry(ProfilerEntry entry)
        {
            _entries.Remove(entry);
        }

        #endregion Registration


        #region Profiling

        /// <summary>
        /// Returns the cumulative time elapsed in nanoseconds from the profiler recorder
        /// </summary>
        /// <returns></returns>
        public long GetCumulativeMS()
        {
            long ms = 0;
            foreach (ProfilerEntry entry in _entries)
            {
                ms += entry.Sampler.GetRecorder().elapsedNanoseconds;
            }
            
            return ms;
        }

        #endregion Profiling
    }
}