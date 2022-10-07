using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AltValue : MonoBehaviour
{
    public Transform planePos;
    public TerrainCollider tercol;
    TMP_Text tmp;
    public float Ftinfo;
    AudioSource aud;
    GetBack getBack;

    void Start() 
    {
        tmp = GetComponent<TMP_Text>();
        tmp.text = "ft. 26,98259";
        aud = GetComponent<AudioSource>();   
        
    }

    void Update()
    {
        giveTransformInfo();
        SfxCall();
    }

    public void giveTransformInfo()
    {
        Ftinfo = ((planePos.transform.position.y) - (tercol.transform.position.y + 100));
        tmp.text = "ft." + " " + Ftinfo.ToString();
    }
    
    void SfxCall()
    {
        if (Ftinfo>120.000 && !aud.isPlaying)
        {
            FindObjectOfType<GetBack>().getbackplay();
            aud.Play();
        }
        else if(Ftinfo<120.000 && aud.isPlaying)
        {
            FindObjectOfType<GetBack>().getBackstop();
            aud.Stop(); 
        }
    }


}

