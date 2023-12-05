using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPet : Pet
{
    [SerializeField] GameObject pet;

    [SerializeField] float playerDistance;

    [SerializeField] public static bool followCommand;

    private void Start()
    {
        //pet = GameObject.FindWithTag("Pet");
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Input follow player");
            followCommand = false;
            GetObserver(PetState.followPlayer);
        }

        else if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Input follow command");
            followCommand = true;
            GetObserver(PetState.followCommand);
        }

        else
        {
            playerDistance = Vector3.Distance(transform.position, pet.transform.position);

            if (followCommand == false && playerDistance < 2f )
            {
                GetObserver(PetState.stay);
            }

            else if (followCommand == false && playerDistance > 2f)
            {
                GetObserver(PetState.followPlayer);
            }
        }
    }
}
