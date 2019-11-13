using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void HorizontalCarMovement()
        {
            ScrollingBody scrolling = new ScrollingBody();
            GameObject car = new GameObject("test");
            car.GetComponent<Rigidbody2D>();

            scrolling.Start();

            //Makes sure the car is moving and not in the Y direction
            float xVector = scrolling.rb2d.velocity.x;
            float yVector = scrolling.rb2d.velocity.y;

            if(xVector < 0)
            {
                xVector *= -1;
            }
            
            Assert.Greater(0, xVector);
            Assert.Equals(0, yVector);

        }
    }
}
