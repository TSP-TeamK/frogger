using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class NewTestScript : MonoBehaviour
    {
        private ScrollingBody scrolling;
        private SoundEffectToggle sound;
        private Sound_Slider_Level slider;
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
        [Test]

        //music
        //check that it plays
        public void SEsoundPlays()
        {
            if (sound == null)
                sound = Instantiate(Resources.Load<SoundEffectToggle>("Prefab/Sound Effect Toggle"));
            PlayerPrefs.SetInt("ToggleSetting", 1);
            sound.Start();
            Toggle toggle = sound.getToggle();
            Text text = sound.getText();
            Assert.AreEqual(true, toggle.isOn);
            Assert.AreEqual("SE ON", text.text);
        }
        [Test]
        public void SEsoundNOTPlays()
        {
            if (sound == null)
                sound = Instantiate(Resources.Load<SoundEffectToggle>("Prefab/Sound Effect Toggle"));
            PlayerPrefs.SetInt("ToggleSetting", 0);
            sound.Start();
            Toggle toggle = sound.getToggle();
            Text text = sound.getText();
            Assert.AreEqual(false, toggle.isOn);
            Assert.AreEqual("SE OFF", text.text);
        }

        //check loudness if slider moves?
 //       [Test]
//        public void soundSliderText()
 //       {
//            //text.text = PlayerPrefs.GetFloat("SoundSliderVolume").ToString() + "%";
//            //slider.GetComponent<Slider>().value = (PlayerPrefs.GetFloat("SoundSliderVolume")) / 100;
//            if (slider == null)
//                slider = Instantiate(Resources.Load<Sound_Slider_Level>("Prefab/slider"));
//            PlayerPrefs.SetFloat("SoundSliderVolume", 100);
//            slider.Start();
//            Slider playerSlider = slider.getSlider();
//            Text text = slider.getText();

//            Assert.AreEqual("100%", text);
//            float value = playerSlider.GetComponent<Slider>().value;
//            Assert.AreEqual(1, value);
//        }


        //sceneLink
        //check that we move to a different scene?

        //frogMovement
        //check start variables initialized 
        //check movement and velocity based on axis?
        //check edgetilemap collision
        //check lives and that they decrease on collision?


    }
}
