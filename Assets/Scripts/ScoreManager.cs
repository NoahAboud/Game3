using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " Points";
    }

    
    public void AddPoint1()
    {
        score += 20;
        scoreText.text = score.ToString() + " Points";
    }
    public void AddPoint2()
    {
        score += 50;
        scoreText.text = score.ToString() + " Points";
    }
}
