using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gravity {
    public static class GlobalVars {
        public static readonly float G = 6.67430f;
        public static GameObject CameraGO;
        public static float forceDiffMagnitudeLimiter = 5f;
        public static GameObject BallPrefab;
    }
}