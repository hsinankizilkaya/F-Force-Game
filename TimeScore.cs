using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeScore : MonoBehaviour
{
    TextMeshProUGUI TimeText;
    FinishTimeOver finishTimeOver;
    
    public int timeCounter = 30;

    void Start()
    {
        TimeText = GetComponent<TextMeshProUGUI>();
        InvokeRepeating("timeDown",0, 1f);   
    }

    void Update()
    {
        timeZero();
    }

    void timeDown()
    {
        timeCounter--;
        TimeText.text =  "time :" + " " + timeCounter.ToString();   
    }

    public void timeup()
    {
        timeCounter++;
    }

    void timeZero()
    {
        if(timeCounter == 0)
        {
            FindObjectOfType<FinishTimeOver>().overtable1();
        }
    }

    
}
