using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereDisable : MonoBehaviour
{
    Animator animator;
    bool inRange=false;

    // Start is called before the first frame update
    private void Start()
    {
        animator=GetComponent<Animator>();
    }
    private void Update()
    {
        if (inRange == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                animator.SetBool("isFading", true);
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange=true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = false;
        }
    }

}
