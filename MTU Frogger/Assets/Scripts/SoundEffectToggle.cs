using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffectToggle : MonoBehaviour
{
    public Text text;
    public Toggle toggle;
    public GameObject player;

    void Start()
    {
        //set sound effect on when game starts
        if (PlayerPrefs.GetInt("ToggleSetting") == 1)
        {
            text.text = "SE ON";
            toggle.isOn = true;
        }
        else
        {
            text.text = "SE OFF";
            toggle.isOn = false;
        }
    }

    public void UpdateText()
    {
        if (toggle.isOn)
        {
            text.text = "SE ON";
        }
        else
        {
            text.text = "SE OFF";
        }
    }

    public void saveVolumeLevel()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("ToggleSetting", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ToggleSetting", 0);
        }
    }

}
