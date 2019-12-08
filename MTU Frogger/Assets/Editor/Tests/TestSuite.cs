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
            scrolling = Instantiate(Resources.Load<ScrollingBody>("Prefab/Car"));
            
            scrolling.Start();

            //Makes sure the car is moving and not in the Y direction
            float xVector = scrolling.getRb2d().velocity.x;
            float yVector = scrolling.getRb2d().velocity.y;

            //Assert throws a weird error. Need to figure out a different way to make test fail
            Assert.NotZero(xVector);
            Assert.Zero(yVector);

            //end test, clean up
            Object.DestroyImmediate(scrolling);
        }
    }
}
