using System;
using UnityEngine;

namespace GGUnityProfiler
{
    public class ProfilerDisplay : MonoBehaviour
    {
        private ProfilerGroup _group;
        public void SetGroup(ProfilerGroup group)
        {
            _group = group;
        }

        private void Update()
        {
            if (_group != null)
            {
                Debug.Log(_group.GetCumulativeMS());
            }
        }
    }
}