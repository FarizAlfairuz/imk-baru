using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public GameObject pauseButtonUI;
    public GameObject gameOverMenuUI;
    void Update() {
        if(GameManager.gameOver == true) {
            pauseButtonUI.SetActive(false);
            GameOver();
        }
    }

    void GameOver(){
        gameOverMenuUI.SetActive(true);
    }
}
