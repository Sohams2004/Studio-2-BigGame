using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wait : State
{

    [SerializeField] NavMeshAgent agent;

    private void OnEnable()
    {
        RunState();
    }
    public override State RunState()
    {
        OnStay();
        return this;
    }

    void OnStay()
    {
        Debug.Log("Staying");
        agent.SetDestination(transform.position);
        agent.enabled = false;

    }

}
