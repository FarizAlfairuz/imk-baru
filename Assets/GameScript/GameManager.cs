using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }
}
