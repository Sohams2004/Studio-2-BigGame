using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject door;
    // Start is called before the first frame update
    // Update is called once per frame

    private void Update()
    {
            foreach (GameObject button in buttons)
            {
            if (button.GetComponent<ChargeConsole>().isActive == false) 
            {
                door.active = true; return; 
            }
            else if (button.GetComponent<ChargeConsole>().isActive == true)
            {
                door.active = false;

            }

        }

    }

}
