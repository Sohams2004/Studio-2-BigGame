using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommandFollow : State
{
    PlayerFollow playerFollow;
    [SerializeField] NavMeshAgent agent;

    Ray cameraRay;

    private void Awake()
    {
        playerFollow=GetComponent<PlayerFollow>();
    }
    public override State RunState()
    {

      

        return this;
    }

    public void Command()
    {
        Debug.Log("Command followed");
        
         cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(cameraRay, out RaycastHit hitInfo, Mathf.Infinity))
        {
            agent.stoppingDistance = 0.001f;
            agent.SetDestination(hitInfo.point);
        }
    }
}
