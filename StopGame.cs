using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopGame : MonoBehaviour
{
    TextMeshProUGUI tmpro;

    void Start()
    {
        tmpro = GetComponent<TextMeshProUGUI>();
        tmpro.enabled = false;
    }

    void Update()
    {
        stopTheGame();
    }

    void stopTheGame()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            tmpro.enabled = true;
            tmpro.text = "PAUSE" + "Press 'P' to continue";
            FindObjectOfType<sfx>().audioClose();
        }

        if(Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 1;
            tmpro.enabled = false;
            FindObjectOfType<sfx>().audioOpen();
        }
        
    }


    
}
