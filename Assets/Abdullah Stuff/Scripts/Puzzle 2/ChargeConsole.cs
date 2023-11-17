using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeConsole : MonoBehaviour
{

    [SerializeField] LineRenderer line;
    [SerializeField] Material[] materials= new Material[2];
    public bool isActive;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player")
        {
            line.material= materials[1];
            isActive = true;
        }
       

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        { 
            line.material = materials[0];
            isActive = false;
        }

    }



}
