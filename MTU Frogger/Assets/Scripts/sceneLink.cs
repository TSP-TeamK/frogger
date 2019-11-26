using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLink : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
    {

        SceneManager.LoadScene(SceneIndex);

    }

    public void LossScreenLoader(int SceneIndex)
    {
        //choosing from loss screen. Reset things back to normal
        GlobalVariables.lives = 3;
        SceneManager.LoadScene(SceneIndex);
    }
}
