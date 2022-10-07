using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTable : MonoBehaviour
{
    TextMeshProUGUI ScoreText;
    FinishTimeOver finishTimeOver;

    public int scoreCounter;
    public int scorePrefab;


    void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
        finishTimeOver = GetComponent<FinishTimeOver>();
    }

    void Update()
    {
        
    }

    public void addScore()
    {
        scoreCounter++;
        ScoreText.text= "SCORE :" + " " + scoreCounter.ToString();
    }



}
