using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gravity;

namespace Gravity {
    public class GlobalVarsSetter : MonoBehaviour {

        [SerializeField] GameObject CameraGO;
        [SerializeField] float forceDiffMagnitudeLimiter = 5f;
        [SerializeField] GameObject BallPrefab;

        private void Awake() {
            GlobalVars.CameraGO = BallPrefab;
            GlobalVars.forceDiffMagnitudeLimiter = forceDiffMagnitudeLimiter;
            GlobalVars.BallPrefab = BallPrefab;
            GlobalVars.ScriptsContainer = gameObject;
        }

    }
}