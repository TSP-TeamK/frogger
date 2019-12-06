using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasterLevel : MonoBehaviour
{
    public Button button;
    public Text tryEasterEggLevel;

    void Start()
    {
        if (PlayerPrefs.GetInt("Score") >= 400)
        {
            button.gameObject.SetActive(true);
            tryEasterEggLevel.gameObject.SetActive(true);
        }
    }
}
