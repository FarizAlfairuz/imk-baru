using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEffect : MonoBehaviour
{
    private bool powerUpIsActivated;
    Rigidbody rigidBody;
    public float powerUpForce = 2f;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("SCharacter_Turtle");
        PlayerCollision collisionScript = player.GetComponent<PlayerCollision>();
        powerUpIsActivated = collisionScript.powerUpIsActivated;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(powerUpIsActivated && collision.gameObject.tag == "Player")
        {
            Debug.Log("Added force");
            rigidBody.AddForce(0,powerUpForce,0, ForceMode.Impulse);
        }
    }
}
