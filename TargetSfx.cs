using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSfx : MonoBehaviour
{
    AudioSource audioo;
    
    
    void Start()
    {
        audioo = GetComponent<AudioSource>(); 
    }
    
    public void calll()
    {
        {
            audioo.Play();
        }
        
    }
}
