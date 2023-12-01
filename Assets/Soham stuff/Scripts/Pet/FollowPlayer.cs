using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour, PetObserver
{
    [SerializeField] Pet pet;

    [SerializeField] GameObject _pet;
    [SerializeField] GameObject _player;

    [SerializeField] Rigidbody petRb;

    [SerializeField] NavMeshAgent meshAgent;

    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindWithTag("Player");
    }

    void Follow_Player()
    {
        Debug.Log("Follow Player");
        CommandPet.followCommand = false;
        meshAgent.SetDestination(_player.transform.position);
    }

    public void Observe(PetState state)
    {
        if (state == PetState.followPlayer)
            Follow_Player();
    }
}
