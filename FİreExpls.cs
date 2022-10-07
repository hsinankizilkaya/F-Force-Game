using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FİreExpls : MonoBehaviour
{
    ParticleSystem ptsm;
    AudioSource audioSource;
    void Start()
    {
        ptsm = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    public void explode()
    {
        ptsm.Play();
    }

    public void crashSFX()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else if(audioSource.isPlaying)
        {
            return;
        }

        
        
    }

}
