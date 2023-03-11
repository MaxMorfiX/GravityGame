using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gravity;

namespace Gravity {
    public class Ball : MonoBehaviour {

        public Rigidbody2D rb;
        private GameController gameController;

        private void OnEnable() {
            rb = GetComponent<Rigidbody2D>();
            gameController = GlobalVars.ScriptsContainer.GetComponent<GameController>();
        }

        public Vector2 CalcAttractionToBall(Ball ball) {

            Vector2 diff = ball.transform.position - transform.position;

            if(diff.magnitude < transform.localScale.x*GlobalVars.forceDiffMagnitudeLimiter) {
                float ang = Mathf.Atan(diff.y/diff.x);

                diff.x = Convert.ToSingle(Math.Cos(ang)*GlobalVars.forceDiffMagnitudeLimiter);
                diff.y = Convert.ToSingle(Math.Sin(ang)*GlobalVars.forceDiffMagnitudeLimiter);
            }

            Vector2 force = diff*GlobalVars.G*ball.rb.mass;

            force /= diff.sqrMagnitude;

            // Debug.Log(diff.sqrMagnitude);
            return force;

        }

        public Vector2 CalcAttractionToBalls(Ball[] balls) {

            Vector2 finForce = new Vector2();

            for(int i = 0; i < balls.Length; i++) {
                Ball ball = balls[i];

                if(ball == this) continue;
                
                finForce += CalcAttractionToBall(ball);
            }

            return finForce;
        }

        public void OnObstacleEnter() {
            gameController.DestroyBall(this);
            Destroy(gameObject);
        }
        
        public void OnFinishEnter() {
            
        }

    }

}