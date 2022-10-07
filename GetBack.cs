using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetBack : MonoBehaviour
{   
    AltValue altValue;
    public TextMeshProUGUI tmm;
    
    void Start()
    {
       tmm = GetComponent<TextMeshProUGUI>();
       tmm.enabled = false;

    }
    
    void Update()
    {

    }

    public void getbackplay()
    {
        {
            tmm.enabled = true;
        }
        
        
    }

    public void getBackstop()
    {
        {
            tmm.enabled = false;
        }
    }         
    
    
}