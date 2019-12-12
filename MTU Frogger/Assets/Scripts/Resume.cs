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
    public void levelSelect1()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Score", 0);
        GlobalVariables.lives = 3;
    }

    public void levelSelect2()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Score", 0);
        GlobalVariables.lives = 3;
    }

    public void levelSelect3()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Score", 0);
        GlobalVariables.lives = 3;
    }

    public void levelSelect4()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Score", 0);
        GlobalVariables.lives = 3;
    }

    public void levelSelectTenacity()
    {
        SceneManager.LoadScene(11);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Score", 0);
        GlobalVariables.lives = 3;
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
