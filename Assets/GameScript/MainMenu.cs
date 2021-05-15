using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        Time.timeScale = 1;
        PauseMenu.pauseButton = false;
        GameManager.gameOver = false;
        SceneManager.LoadScene("SampleScene");
    }

    public void Credit(){
        SceneManager.LoadScene("Credits");
    }
    public void BackToMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void Restart(){
        Time.timeScale = 1;
        PauseMenu.pauseButton = false;
        GameManager.gameOver = false;
        SceneManager.LoadScene("SampleScene");
        Debug.Log(PauseMenu.pauseButton);
    }
    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void About(){
        SceneManager.LoadScene("About");
    }

    public void Pause(){
        Time.timeScale = 0;
        SceneManager.LoadScene("Pause");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
