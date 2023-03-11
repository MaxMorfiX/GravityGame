using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gravity {

    public class Finish : MonoBehaviour {
        private void OnCollisionEnter2D(Collision2D col) {
            if(col.gameObject.CompareTag("Ball")) {
                Ball ball = col.gameObject.GetComponent<Ball>();
                ball.OnFinishEnter();
            }
        }
    }

}

