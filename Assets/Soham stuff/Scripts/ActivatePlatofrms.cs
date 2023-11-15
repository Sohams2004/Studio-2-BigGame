using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlatofrms : MonoBehaviour
{
    [SerializeField] bool isOrangeConsole, isYellowConsole, isRedConsole;

    [SerializeField] OrangePlatforms orangePlatform;
    [SerializeField] YellowPlatform yellowPlatform;
    [SerializeField] RedPlatform redPlatform;

    private void Start()
    {
        orangePlatform = FindObjectOfType<OrangePlatforms>();
        yellowPlatform = FindObjectOfType<YellowPlatform>();
        redPlatform = FindObjectOfType<RedPlatform>();

        orangePlatform.enabled = false;
        yellowPlatform.enabled = false;
        redPlatform.enabled = false;
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Yellow Console"))
        {
            isYellowConsole = true;
        }
       
        if (other.gameObject.CompareTag("Orange Console"))
        {
            isOrangeConsole = true;
        }
        
        if (other.gameObject.CompareTag("Red Console"))
        {
            isRedConsole = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isOrangeConsole = false;
        isYellowConsole = false;
        isRedConsole = false;
    }

    void ActivateOrangeConsole()
    {
        if (isOrangeConsole)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacted with the orange console");
                orangePlatform.enabled = true;
            }
        }
    }

    void ActivateYellowConsole()
    {
        if (isYellowConsole)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacted with the yellow console");
                yellowPlatform.enabled = true;
            }
        }
    }

    void ActivateRedConsole()
    {
        if (isRedConsole)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacted with the Red console");
                redPlatform.enabled = true;
            }
        }
    }

    private void Update()
    {
        ActivateOrangeConsole();
        ActivateYellowConsole();
        ActivateRedConsole();
    }
}
