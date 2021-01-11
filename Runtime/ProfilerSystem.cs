using GGUnityData;
using GGUnityProfiler.Data;
using GGUnityUtility;
using UnityEngine;

namespace GGUnityProfiler
{
    public class ProfilerSystem : UnityCoreSystemBase<ProfilerGroup>
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
            // foreach (IUnitySystemComponent component in Components)
            // {
            //     Debug.Log(((ProfilerGroup)component).GetCumulativeMS() / 1000);
            // }
        }

        #endregion Display
    }
}