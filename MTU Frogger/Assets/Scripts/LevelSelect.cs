using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Button button;
    public Text tryEasterEggLevel;
    public Button levelSelect;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            PlayerPrefs.SetInt("allLevelCleared", 1);
        }
        if (PlayerPrefs.GetInt("Score") >= 500)
        {
            button.gameObject.SetActive(true);
            tryEasterEggLevel.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("allLevelCleared") == 1)
        {
            levelSelect.gameObject.SetActive(true);
        }
    }
}
