using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Sound_Slider_Level : MonoBehaviour
{
    public Text text;
    public Slider slider;
    public AudioMixer mixer;

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    public void UpdateText()
    {
        text.text = ((int)(slider.value * 100)).ToString() + "%";
    }

    public void Start()
    {
        text.text = PlayerPrefs.GetFloat("SoundSliderVolume").ToString() + "%";
        slider.GetComponent<Slider>().value = (PlayerPrefs.GetFloat("SoundSliderVolume"))/100;
    }

    public void saveVolumeLevel()
    {
        PlayerPrefs.SetFloat("SoundSliderVolume", (int)(slider.value * 100));
    }

    public Text getText()
    {
        return text;
    }

    public Slider getSlider()
    {
        return slider;
    }
}
