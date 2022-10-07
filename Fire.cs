using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    ParticleSystem fireParticles;
    bool FirePartclEnabled = false;
    AudioSource sourceSfx;
    [SerializeField] AudioClip shootingSfx;
    public TargetSfx targetSfx;
    
    void Start()
    {
        fireParticles = GetComponent<ParticleSystem>();
        sourceSfx = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        firee();
        enablee();
        FireSfx();
    }

    void enablee()
    {
        var emission = fireParticles.emission;
        emission.enabled = FirePartclEnabled;
    }

    void firee()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            FirePartclEnabled = true;  
            
        }
        else
        {
            FirePartclEnabled = false;    
        }
    }

    void FireSfx()
    {
        if (!sourceSfx.isPlaying && FirePartclEnabled == true)
        {
            sourceSfx.PlayOneShot(shootingSfx);
            targett();
        }

        else if (sourceSfx.isPlaying && FirePartclEnabled == false)
        {
            sourceSfx.Stop();
        }
    }

    void targett()
    {
        FindObjectOfType<TargetSfx>().calll();
    }

}
