using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wait : State
{
    [SerializeField] bool wait;

    [SerializeField] NavMeshAgent agent;

    public override State RunState()
    {
        OnStay();
        return this;
    }

    void OnStay()
    {
        Debug.Log("Staying");
        wait = true;
        agent.enabled = true;
        agent.SetDestination(transform.position);
    }
}
