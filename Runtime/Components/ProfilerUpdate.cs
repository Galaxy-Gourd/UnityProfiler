using UnityEngine;

namespace GGUnityProfiler
{
    public class ProfilerUpdate : MonoBehaviour
    {
        #region Variables

        private ProfilerSystem _system;
        private bool _initialized;

        #endregion Variables
        
        
        #region Initialization

        public void Initialize(ProfilerSystem sys)
        {
            transform.name = "_ProfilerUpdate";
            DontDestroyOnLoad(gameObject);
            
            _system = sys;
            _initialized = true;
        }

        #endregion Initialization
        
        
        #region Update

        private void Update()
        {
            if (!_initialized)
                return;
            
            _system.Update();
        }

        #endregion Update
    }
}