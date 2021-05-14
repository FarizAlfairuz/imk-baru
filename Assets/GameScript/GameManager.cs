using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("Game Over");
        }
    }
}
