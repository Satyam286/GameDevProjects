using UnityEngine;

public class MovObstacle : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;
    public Vector3 direction = Vector3.right; // or Vector3.forward

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + direction * move;
    }
}
