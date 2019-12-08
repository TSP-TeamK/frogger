using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    //for resume button
    public void resume()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastLevel"));
        Time.timeScale = 1f;
    }
    //for level select buttons
    public void levelSelect()
    {
        Time.timeScale = 1f;
    }
    public void StartNewGame()
    {
        Time.timeScale = 1f;
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(5);
    }
}
