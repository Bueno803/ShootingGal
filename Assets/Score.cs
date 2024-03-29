using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void IncreaseScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score.ToString();
    }

    public int GetScore() 
    {
        return this.score;
    }
}
