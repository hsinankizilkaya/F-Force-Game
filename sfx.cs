using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public AudioSource audioSource;
    TimeScore timeScore;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioOpen();
    }

    void Update()
    {        
        noSound();
    }

    public void noSound()
    {
        if(FindObjectOfType<FinishTimeOver>().timefinished == true)
        {
            audioClose();
        }
    }

    public void audioClose()
    {
        audioSource.Stop();
    }

    public void audioOpen()
    {
        audioSource.Play();
    }
}
