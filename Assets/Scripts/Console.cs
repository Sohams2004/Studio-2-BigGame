using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    [SerializeField] GameObject consoleText;
    [SerializeField] bool consoleActivated;

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            consoleActivated = true; 
            consoleText.SetActive(true);
        }  
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        consoleText.SetActive(false);
        consoleActivated = false;
    }

    private void Update()
    {
        if(consoleActivated)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacted with the console");
            }
        }
    }
}
