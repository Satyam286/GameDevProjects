using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Don't destroy on scene change
        }
        else
        {
            Destroy(gameObject); // Kill any duplicates
        }
    }
}
