using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private float speed = 0.05f;
    void Update()
    {
        if(PauseMenu.pauseButton == true) {
            speed = 0f;
        }
        transform.Translate(Input.acceleration.x * speed, 0, 0);
        if(GameManager.gameOver == true) {
            speed = 0f;
        }
        
    } 
}
