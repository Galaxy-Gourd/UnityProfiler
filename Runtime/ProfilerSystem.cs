using GGUnityData;
using GGUnityProfiler.Data;
using GGUnityUtility;
using UnityEngine;

namespace GGUnityProfiler
{
    public class ProfilerSystem : UnityCoreSystemBase<ProfilerData>
    {
        #region Variables
        

        #endregion Variables
        
        
        #region Construction

        public ProfilerSystem(ProfilerSystemConfigData data) : base(data)
        {
            GameObject obj = Instantiator.Instantiate() as GameObject;
            ProfilerUpdate p = obj.AddComponent<ProfilerUpdate>();
            p.Initialize(this);
        }

        #endregion Construction


        #region Display

        public void Update()
        {
            foreach (ProfilerData component in _components)
            {
                
            }
        }

        #endregion Display
    }
}