using UnityEngine;

public class MoveObstacles : MonoBehaviour
{

    public float speed;
    private bool onTreadmill = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onTreadmill == true)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Treadmill")
        {
            this.onTreadmill = true;
        }
    }
}
