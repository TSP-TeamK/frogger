using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeLevelChange : MonoBehaviour
{
    public Slider audioSlider;
  public void OnValueChanged()
    {
        AudioListener.volume = audioSlider.value;
    }
}
