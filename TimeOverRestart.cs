using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeOverRestart : MonoBehaviour
{
    Button btn;
    TextMeshProUGUI tmeshpPro;
    FinishTimeOver finishTimeOver;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Rest);
        tmeshpPro = GetComponent<TextMeshProUGUI>();
        tmeshpPro.enabled = false;
        Time.timeScale = 1;
    }

    
    void Update()
    {
        TimeOverRes();
    }

    void TimeOverRes()
    {
        {
            if(FindObjectOfType<FinishTimeOver>().timefinished == true)
            {
                tmeshpPro.enabled = true;
                tmeshpPro.text = "Restart";
            }
        }
        
    }

    void Rest() 
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }


}
