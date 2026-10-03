using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour{


    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

        bool gameHasEnded = false;
    public void EndGame()


    {

        if(gameHasEnded == false)
        {
         gameHasEnded = true;        
            Invoke("Restart", 1f );
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
