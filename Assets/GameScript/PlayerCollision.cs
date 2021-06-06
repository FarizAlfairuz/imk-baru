using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public PlayerMovement movement;
    public float powerUpDuration = 1f;
    public bool powerUpIsActivated = false;
    public GameObject shield;
    public GameObject pickupEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles" && powerUpIsActivated == false)
        {
            //movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            StartCoroutine(Pickup(collision.gameObject));
        }
    }

    IEnumerator Pickup(GameObject obj)
    {
        Debug.Log("Power up is activated");
        //Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(obj);
        powerUpIsActivated = true;
        shield.GetComponent<MeshRenderer>().enabled = true;
        GameObject effect =  Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(effect, 1);

        yield return new WaitForSeconds(powerUpDuration);

        shield.GetComponent<MeshRenderer>().enabled = false;
        powerUpIsActivated = false;
        Debug.Log("Power up is deactivated");
    }
}
