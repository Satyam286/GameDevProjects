using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText; // reference for High Score UI
    public GameObject gameOverScreen;
    public AudioClip scoreSound;           //  Sound file
    private AudioSource audioSource;       //  For playing it


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // show saved high score when the game starts
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore;
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();

        audioSource.PlayOneShot(scoreSound);

        if (playerScore % 5 == 0)
        {
            
            PipeMove.moveSpeed += 2f; // Adjust the increase as you like
            PipeMove.moveSpeed = Mathf.Min(PipeMove.moveSpeed, 200f);
        }


        //  Update high score
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (playerScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            PlayerPrefs.Save();
            highScoreText.text = "High Score: " + playerScore;
        }
    }

    public void restartGame()
    {
        PipeMove.moveSpeed = 5f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
