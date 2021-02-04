using System;
using UnityEngine;

namespace GGUnityProfiler
{
    public class ProfilerDisplay : MonoBehaviour
    {
        private ProfilerData _data;
        public void SetGroup(ProfilerData data)
        {
            _data = data;
        }

        private void Update()
        {
            if (_data != null)
            {
                Debug.Log(_data.GetCumulativeMS());
            }
        }
    }
}