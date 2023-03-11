using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gravity;

namespace Gravity {
    public class GameController : MonoBehaviour {

        Ball[] balls = new Ball[0];

        private void FixedUpdate() {
            for(int i = 0; i < balls.Length; i++) {
                Ball ball = balls[i];

                ball.rb.AddForce(ball.CalcAttractionToBalls(balls));
            }
        }

        public Ball AddBall() {
            return AddBall(new Vector3());
        }

        public void DestroyBall(Ball ball) {
            int index = Array.IndexOf(balls, ball);

            var ballsList = new List<Ball>(balls);
            ballsList.RemoveAt(index);
            balls = ballsList.ToArray();
        }

        public Ball AddBall(Vector3 pos) {
            Ball ball = Instantiate(GlobalVars.BallPrefab).GetComponent<Ball>();
            ball.transform.position = pos;
            Array.Resize(ref balls, balls.Length + 1);
            balls[balls.Length - 1] = ball;

            return ball;
        }

        private void Start() {
            AddBall();
            AddBall(new Vector3(0.3f, 0.3f, 0));
        }

    }
}
