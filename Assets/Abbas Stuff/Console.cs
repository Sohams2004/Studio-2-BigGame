using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Console : MonoBehaviour
{
    public bool powered = false;
    [SerializeField] GameObject elevator;


    private void OnTriggerEnter2D(Collider2D other)
    {
        print("triggered");
        powered = true;
    }

    public void Update()
    {
        if (powered == true)
            if (Input.GetKey(KeyCode.E))
            {
                powered = true;
                if (powered == true & elevator.transform.position.y == -4.75f)
                {
                    elevator.transform.position = new Vector3();
                }
                else if (powered == true & elevator.transform.position.y == 0.75f)
                {
                    elevator.transform.position = Vector3.down;
                }
                else
                {
                    elevator.transform.position = Vector3.zero;
                }
            }
    }
}
