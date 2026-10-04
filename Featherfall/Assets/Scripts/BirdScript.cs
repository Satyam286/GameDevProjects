using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioClip flapSound;
    public AudioClip deathSound;

    public InputActionReference jumpAction;

    private AudioSource audioSource;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        jumpAction.action.Enable();
        jumpAction.action.performed += OnJump;
    }

    void OnDisable()
    {
        jumpAction.action.performed -= OnJump;
        jumpAction.action.Disable();
    }

    void OnJump(InputAction.CallbackContext context)
    {
        if (!birdIsAlive)
            return;

        myRigidBody.linearVelocity = Vector2.up * flapStrength;
        audioSource.PlayOneShot(flapSound);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        audioSource.PlayOneShot(deathSound);
        birdIsAlive = false;
    }
}