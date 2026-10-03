using UnityEngine;

public class SpinObstacle : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0f, 0f, 100f); // adjust for xyz spin

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
