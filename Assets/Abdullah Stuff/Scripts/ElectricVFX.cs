using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricVFX : MonoBehaviour
{
    public Transform electricityEndPoint;
    
    private void Start()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "ElectricBot")
        {
            Vector3 robotPos= other.transform.position;
            robotPos.y += 0.5f;
            other.GetComponent<LineRenderer>().enabled=true;
            other.GetComponent<LineRenderer>().SetPosition(0, electricityEndPoint.position);
            other.GetComponent<LineRenderer>().SetPosition(1, robotPos);

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ElectricBot")
        {
            other.GetComponent<LineRenderer>().enabled = false;
        }

    }


}
