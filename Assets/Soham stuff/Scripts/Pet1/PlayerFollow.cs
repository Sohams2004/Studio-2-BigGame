using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFollow : State
{

    [SerializeField] NavMeshAgent agent;
    public float followDistance =1;
    [SerializeField] GameObject player;


    public override State RunState()
    {
        Follow_Player();
        return this;
    }

    void Follow_Player()
    {
        agent.enabled = true;

        Debug.Log("Follow player");
        agent.stoppingDistance = followDistance;
        agent.SetDestination(player.transform.position);
    }

 }
