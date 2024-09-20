using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private int score;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void IncreaseScore(int clickPoint)
    {
        score += clickPoint;
        scoreText.text = "Score: " + score.ToString();
    }
}
