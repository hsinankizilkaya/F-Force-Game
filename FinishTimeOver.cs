using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishTimeOver : MonoBehaviour
{
    TextMeshProUGUI tmeshpPro;
    ScoreTable scoreTable;
    
    public bool timefinished;

    void Start()
    {
        tmeshpPro = GetComponent<TextMeshProUGUI>();
        tmeshpPro.enabled = false;
    }
 
    public void overtable1()
    {
        timefinished = true;
        tmeshpPro.enabled = true;
        tmeshpPro.text = "Time is over";
        Time.timeScale = 0;
    }
}
