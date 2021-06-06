using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUp;

    public Vector3 center;
    public Vector3 size;

    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;



    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            // execute block of code here
            SpawnPowerUp();
        }
    }

    public void SpawnPowerUp()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), center.y, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(powerUp, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
