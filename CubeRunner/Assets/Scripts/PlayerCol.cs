using UnityEngine;

public class PlayerCol : MonoBehaviour
{

    public PlayerMov movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindFirstObjectByType<GameManager>().EndGame();
        }


    }
}