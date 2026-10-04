using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public static float moveSpeed = 10f;   //  static so we can change it globally
    public float deadZone = -40f;

    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
