using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
     private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log ("Door1") ;
            anim.SetTrigger("OpenDoor");
            
        }
    }

   //private void OnCollisionEnter(Collision collision)
   //{
   //    GameObject collisionGameObject = collision.gameObject;

   //    if (collisionGameObject.tag == "Player")
   //    {
   //        
   //        Debug.Log ("Door1") ;
   //        anim.SetTrigger("OpenDoor");
   //    }
   //}

}
