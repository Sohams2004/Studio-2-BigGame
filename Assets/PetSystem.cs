using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSystem : MonoBehaviour
{
    public int petcount;

    public Renderer rend;

    public Material off;

    public Material on;

    public GameObject Console;




    public void Start()
    {
        rend = GetComponent<Renderer>();

    }
    private void Update()
    {
        // Check for the "E" key press outside of OnTriggerEnter
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressed E");
            if (petcount >= 1)
            {
                petcount--;
                Debug.Log("Powering up");
            }
        }
    }

    public void AddPet()
    {
        petcount++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pet"))
        {
            AddPet();
            Destroy(other.gameObject);
            Debug.Log("pet count: " + petcount);
        }

        if (other.CompareTag("Console"))
        {
            Debug.Log("At console press 'E' to power up");
        }
    }
}

