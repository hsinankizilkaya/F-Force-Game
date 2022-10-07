using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float ThrustForce2 = 100f;
    [SerializeField] float turnSpeed = 30f;
    [SerializeField] float aimSpeed = 1f;    
    [SerializeField] float GravityScale = 1f;  
   
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movementt();
    }

    public void movementt()
    {
        Physics.gravity = new Vector3(0,-GravityScale,0);
        
        rb.transform.Translate(0,0,ThrustForce2 * Time.deltaTime);

         if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0,0,turnSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(0,0,-turnSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.transform.Rotate(-aimSpeed,0,0 *Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.transform.Rotate(aimSpeed,0,0 *Time.deltaTime);
        }
    }

}

        