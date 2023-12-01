using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFollow : State
{
    [SerializeField] public bool followPlayer;

    [SerializeField] NavMeshAgent agent;

    [SerializeField] GameObject player;


    private void Start()
    {
        followPlayer = true;
    }

    public override State RunState()
    {
        if (Input.GetMouseButtonDown(1) && followPlayer == false)
        {
            Follow_Player();
        }

        return this;
    }

    void Follow_Player()
    {
        Debug.Log("Follow player");
        followPlayer = true;
        agent.SetDestination(player.transform.position);
    }
}
