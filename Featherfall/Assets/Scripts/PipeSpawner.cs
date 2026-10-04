using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float heightOffset = 10f;

    private float timer = 0f;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        float moveSpeed = PipeMove.moveSpeed;

        //  Starts at 3s when speed = 5, gets faster as speed increases
        float spawnRate = Mathf.Max(0.7f, 15f / moveSpeed);

        timer += Time.deltaTime;

        if (timer > spawnRate)
        {
            spawnPipe();
            timer = 0f;
        }
    }


    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0f), transform.rotation);
    }
}
