using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text scoreText;
    int score, highScore;

    public void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        highScore = PlayerPrefs.GetInt("HighScore");
    }
    public void ScoreIncrement()
    {
        score++;
        scoreText.text = score.ToString();
        if (score>highScore)
        {
            highScore = score;
            Debug.Log("HighScore: " + highScore);
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
