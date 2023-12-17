using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;

public class RobotAnimation : MonoBehaviour
{
    StateManager stateManager;
    Animator animator;
    NavMeshAgent agent;

    private void Start()
    {
        animator = GetComponent<Animator>();
        stateManager = GetComponent<StateManager>();
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        
        if (stateManager.botState == BotState.waiting)
        {
            animator.SetBool("Follow", false);
            animator.SetBool("Walk", false);
            animator.SetBool("Wait", true);
        }

        if (stateManager.botState == BotState.commanded)
        {

            animator.SetBool("Follow", false);
            animator.SetBool("Wait", false);
            animator.SetBool("Walk", true);
        }

        if (stateManager.botState == BotState.followPlayer)
        {
            animator.SetBool("Wait", false);
            animator.SetBool("Walk", false);
            if (agent.remainingDistance > agent.stoppingDistance)
            {

                animator.SetBool("Follow", true);

            }
            else animator.SetBool("Follow", false);



        }



    }
    

}
