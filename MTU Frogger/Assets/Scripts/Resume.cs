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

    //for start new game button
    public void StartNewGame()
    {
        Time.timeScale = 1f;
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("lastLevel");
        //PlayerPrefs.DeleteKey("allLevelCleared");
        //PlayerPrefs.DeleteKey("easterLevelUnlocked");
        GlobalVariables.lives = 3;
        SceneManager.LoadScene(5);
    }

    //for quit button
    public void quitGame()
    {
        Application.Quit();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("lastLevel");
        PlayerPrefs.DeleteKey("allLevelCleared");
        PlayerPrefs.DeleteKey("easterLevelUnlocked");
    }
}
