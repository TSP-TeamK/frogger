using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pausePanel;
    public void PauseGame() {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame() {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;

    }
}
