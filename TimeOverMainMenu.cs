using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeOverMainMenu : MonoBehaviour
{ 
    Button btn;
    TextMeshProUGUI tmeshpPro;
    FinishTimeOver finishTimeOver;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(GoMain);
        tmeshpPro = GetComponent<TextMeshProUGUI>();
        tmeshpPro.enabled = false;
        Time.timeScale = 1;
    }

    
    void Update()
    {
        overmainn();
    }

    void overmainn()
    {
        {
            if(FindObjectOfType<FinishTimeOver>().timefinished == true)
            {
                tmeshpPro.enabled = true;
                tmeshpPro.text = "Main Menu";
            }
        }
        
    }

    void GoMain() 
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    
}
