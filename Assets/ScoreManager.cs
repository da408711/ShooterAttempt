using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score = 0;
    internal static int scoreValue;
    internal static int scoreAmount;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
    }

    private void Awake()
    {
        instance = this;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Score";
    }
}
