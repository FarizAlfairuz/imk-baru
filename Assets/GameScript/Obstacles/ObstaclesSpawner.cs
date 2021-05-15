using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject obstacles;
    public GameObject permenkaret;
    GameObject rintangan;

    public Vector3 center;
    public Vector3 size;

    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        rintangan = obstacles;
        SpawnObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            // execute block of code here
            SpawnObstacles();
        }
    }

    public void SpawnObstacles()
    {
        
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        if(rintangan == obstacles) {
            Instantiate(rintangan, pos, Quaternion.identity);
            rintangan = permenkaret;
        } else {
            Instantiate(rintangan, pos, Quaternion.identity);
            rintangan = obstacles;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
