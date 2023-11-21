using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeConsole : MonoBehaviour
{

    [SerializeField] LineRenderer line;
    [SerializeField] Material[] materials= new Material[2];
    [SerializeField] GameObject door;
    public bool isActive;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isActive == false)
        {
            line.material= materials[1];
            isActive = true;
            door.GetComponent<SwitchDoor>().CountingButtons(1);
        }
       

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && isActive == true)
        { 
            line.material = materials[0];
            isActive = false;
            door.GetComponent<SwitchDoor>().CountingButtons(-1);
        }

    }



}
