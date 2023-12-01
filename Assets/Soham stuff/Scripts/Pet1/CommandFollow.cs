using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommandFollow : State
{
    PlayerFollow playerFollow;

    [SerializeField] bool followCommand;

    [SerializeField] LayerMask groundMask;

    [SerializeField] NavMeshAgent agent;

    Ray cameraRay;

    public override State RunState()
    {
        if (Input.GetMouseButtonDown(0) && followCommand == false)
        {
            Command();
        }

        return this;
    }

    void Command()
    {
        Debug.Log("Command followed");
       
        playerFollow.followPlayer = false;
        followCommand = true;

        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(cameraRay, out RaycastHit hitInfo, Mathf.Infinity, groundMask))
        {
            agent.SetDestination(hitInfo.point);
        }
    }
}
