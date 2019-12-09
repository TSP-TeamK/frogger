using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript : MonoBehaviour
    {
        private ScrollingBody scrolling;
        // A Test behaves as an ordinary method
        [Test]
        public void HorizontalCarMovement()
        {
            if(scrolling == null)
                scrolling = Instantiate(Resources.Load<ScrollingBody>("Prefab/Car"));
            
            scrolling.Start();

            //Makes sure the car is moving and not in the Y direction
            float xVector = scrolling.getRb2d().velocity.x;
            float yVector = scrolling.getRb2d().velocity.y;

            Assert.NotZero(xVector);
            Assert.Zero(yVector);
        }
        [Test]
        public void HuskyNotNull()
        {
            if(scrolling == null)
                scrolling = Instantiate(Resources.Load<ScrollingBody>("Prefab/Car"));

            scrolling.Awake();
            GameObject player = scrolling.getPlayer();
            Assert.NotNull(player);

        }
        [Test]
        public void restartNotNull()
        {
            if(scrolling == null)
                scrolling = Instantiate(Resources.Load<ScrollingBody>("Prefab/Car"));

            scrolling.Awake();
            Vector2 restart = scrolling.getRestartPos();
            Assert.NotNull(restart);

        }
       // [Test]

        //can I cause a collision and see what happens?

        //music
        //check that it plays
        //check loudness if slider moves?


        //sceneLink
        //check that we move to a different scene?

        //frogMovement
        //check start variables initialized 
        //check movement and velocity based on axis?
        //check edgetilemap collision
        //check lives and that they decrease on collision?


    }
}
