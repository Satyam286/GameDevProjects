using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
