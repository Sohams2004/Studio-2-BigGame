using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Entity : MonoBehaviour
{
    Collider entityCollider;
    Rigidbody rb;
    public Collider EntityCollider { 
    
        get 
        {
            return entityCollider; 
        } 
    }
    void Awake()
    {
        //where am I using it ?
       // entityCollider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Move(Vector3 velocity)
    {
        //facing direction;
        transform.forward = Vector3.Lerp(transform.forward, velocity, Time.deltaTime);
        

        //movement
        rb.AddForce(velocity * Time.deltaTime,ForceMode.VelocityChange);



    }



}
