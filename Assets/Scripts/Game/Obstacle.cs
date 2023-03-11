using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gravity;

namespace Gravity {
    public class Obstacle : MonoBehaviour {

        private void OnCollisionEnter2D(Collision2D col) {
            if(col.gameObject.CompareTag("Ball")) {
                Ball ball = col.gameObject.GetComponent<Ball>();
                ball.OnObstacleEnter();
            }
        }

    }
}