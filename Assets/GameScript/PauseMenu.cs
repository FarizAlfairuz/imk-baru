using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool pauseButton = GameIsPaused;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (pauseButton == false)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void PauseButton()
    {
        pauseButton = !GameIsPaused;
        Debug.Log("game button is " + pauseButton);
    }

    public void ContinueButton()
    {
        pauseButton = GameIsPaused;
        Debug.Log("game button is " + pauseButton);
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        if(GameManager.gameOver == false){
            Time.timeScale = 1;
        }
        // GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        // GameIsPaused = true;
    }
}
