using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance;
    int score = 0;
    public TMPro.TextMeshProUGUI scoreText;
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + Mathf.Round(score);
    }
    private void Awake()
    { // Singleton Pattern
        if(GameManagerInstance == null)
            GameManagerInstance = this;
        else
        {
            Destroy(this);
        }
    }


    public void AddScore()
    {
        score++;
        UpdateScoreText();
    }
}
