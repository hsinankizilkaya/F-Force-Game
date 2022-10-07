using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawner : MonoBehaviour
{   
    public ParticleSystem BombEffect;
    public ParticleSystem BombEffect2;
    public ParticleSystem BombEffect3;

    ScoreTable scoreTable;
    TimeScore timeScore;
    AudioSource audioSource;
    
    private void Start() 
    {
        BombEffect.Play();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Terrain")
        {
            BombEffect3.Play();
            Destroy(gameObject,0.5f);
        }
    }

    private void OnParticleCollision(GameObject other) 
    {
        if (other.tag == "FireParticles")
        {
            
            FindObjectOfType<ScoreTable>().addScore();
            FindObjectOfType<TimeScore>().timeup();
            BombEffect2.Play();
            Destroy(gameObject,0.15f); 
            audioSource.Play(); 
        }
        
    }
        
}
