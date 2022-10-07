using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    ParticleSystem pstm;
    [SerializeField] float LoadDelay = 2f;
    Rigidbody rb;
    FİreExpls fİreExpls;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnCollisionEnter(Collision other) 
    {
        FindObjectOfType<PlayerController>().enabled = false;
        rb.useGravity = true;
        Physics.gravity = new Vector3(0,-20f,0);
        Invoke("reloadScene",LoadDelay);
        FindObjectOfType<FİreExpls>().explode();
        FindObjectOfType<FİreExpls>().crashSFX();
    }


    void reloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0); 
    }


}
