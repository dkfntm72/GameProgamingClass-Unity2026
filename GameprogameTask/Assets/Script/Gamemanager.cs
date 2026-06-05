using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    private float gameTimer;

    public GameObject endImage;
    private void Start()
    {
        timerText.text = "30";
        gameTimer = 30;
    }

    private void Update()
    {
        gameTimer -= Time.deltaTime;

        if(gameTimer<=0.0f)
        {
            Time.timeScale = 0;
            endImage.SetActive(true);
        }

        timerText.text = gameTimer.ToString("n1");

        scoreText.text = "Score : " + score;
    }

    public void StartButtonClick()
    {
        endImage.SetActive(false);
        Time.timeScale = 1;
        gameTimer = 30;
        score = 0;

    }
    public void GameEndButtonClick()
    {
        Application.Quit();
    }
}
