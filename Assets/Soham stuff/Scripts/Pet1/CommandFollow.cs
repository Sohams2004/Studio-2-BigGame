using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommandFollow : State
{
    PlayerFollow playerFollow;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Camera camera;

 //   [SerializeField] GameObject pingMarker;

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
        agent.enabled = true;

        cameraRay = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(cameraRay, out RaycastHit hitInfo, Mathf.Infinity,~8 ,QueryTriggerInteraction.Ignore))
        {
            agent.stoppingDistance = 0.001f;
            agent.SetDestination(hitInfo.point);

                //            Instantiate(pingMarker, hitInfo.point, Quaternion.identity);
        }
    }
}
