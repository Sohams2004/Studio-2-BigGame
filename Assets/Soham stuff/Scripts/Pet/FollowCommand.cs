using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowCommand : MonoBehaviour,PetObserver
{
    Ray cameraRay;

    [SerializeField] Pet pet;

    [SerializeField] LayerMask layerMask;

    [SerializeField] NavMeshAgent agent;

    void Command()
    {
        Debug.Log("Follow command");
        CommandPet.followCommand = false;
        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(cameraRay, out RaycastHit hitInfo, Mathf.Infinity, layerMask) )
        {
            agent.SetDestination(hitInfo.point);
        }
    }

    public void Observe(PetState state)
    {
        if (state == PetState.followCommand)
            Command();
    }
}
