using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Stay : MonoBehaviour, PetObserver
{
    [SerializeField] Pet pet;

    [SerializeField] NavMeshAgent agent;

    void OnStay()
    {
        Debug.Log("Staying");
        agent.enabled = true;
        agent.SetDestination(transform.position);
    }

    public void Observe(PetState state)
    {
        if (state == PetState.stay)
            OnStay();
    }
}
